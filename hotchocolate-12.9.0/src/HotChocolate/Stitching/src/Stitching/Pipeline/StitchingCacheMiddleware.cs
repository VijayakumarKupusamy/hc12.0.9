using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Execution;
using HotChocolate.Stitching.Extensions;
using Newtonsoft.Json.Linq;

namespace HotChocolate.Stitching.Pipeline;
internal class StitchingCacheMiddleware
{
    private readonly RequestDelegate _next; 

    private static ConcurrentDictionary<string, IExecutionResult> inMemCache = new ConcurrentDictionary<string, IExecutionResult>();
    
    public StitchingCacheMiddleware(
              RequestDelegate next)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next)); 
    }

    public async ValueTask InvokeAsync(IRequestContext context)
    {
        if (inMemCache.TryGetValue(context?.DocumentId, out IExecutionResult? cachedResult))
        {
            //IReadOnlyDictionary<string, object?> cachedData = JObject.Parse(cachedResult).ToDictionary();
            //context.Result = QueryResultBuilder.New()
            //                .SetData(cachedData["data"] as IReadOnlyDictionary<string, object?>)
            //                .Create();
            context.Result = cachedResult;
        }
        else
        {         

            await _next.Invoke(context).ConfigureAwait(false);

            inMemCache.TryAdd(context.DocumentId, context.Result);
        }

    }
}
