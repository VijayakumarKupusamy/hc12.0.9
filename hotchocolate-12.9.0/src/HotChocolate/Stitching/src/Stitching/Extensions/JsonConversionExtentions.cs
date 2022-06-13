using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using HotChocolate.Execution.Configuration;
using HotChocolate.Stitching.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace HotChocolate.Stitching.Extensions;
public static class JsonConversionExtensions
{
    public static IRequestExecutorBuilder UseCacheHttpRequests(
          this IRequestExecutorBuilder builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }
        return builder.UseRequest<StitchingCacheMiddleware>();
    }
    public static IReadOnlyDictionary<string, object?> ToDictionary(this JObject json)
    { 
string jsonString = JsonConvert.SerializeObject(json, //Newtonsoft.Json.Formatting.Indented,
new JsonSerializerSettings
{
    NullValueHandling = NullValueHandling.Ignore,
    StringEscapeHandling = StringEscapeHandling.EscapeNonAscii,
    DefaultValueHandling = DefaultValueHandling.Ignore
}); 


        Dictionary<string, object?> propertyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, object?>>(jsonString);

        
        ProcessJObjectProperties(propertyValuePairs);
        ProcessJArrayProperties(propertyValuePairs);
        return propertyValuePairs;
    }

    private static void ProcessJObjectProperties(IDictionary<string, object?> propertyValuePairs)
    {
        var objectPropertyNames = (from property in propertyValuePairs
                                   let propertyName = property.Key
                                   let value = property.Value
                                   where value is JToken 
                                   select propertyName).ToList();

        objectPropertyNames.ForEach((propertyName) =>
        { 
            propertyValuePairs[propertyName] = ToDictionary((JObject)propertyValuePairs[propertyName]);
        });
    }

    private static void ProcessJArrayProperties(IDictionary<string, object?> propertyValuePairs)
    {
        var arrayPropertyNames = (from property in propertyValuePairs
                                  let propertyName = property.Key
                                  let value = property.Value
                                  where value is JArray
                                  select propertyName).ToList();

        arrayPropertyNames.ForEach(propertyName => propertyValuePairs[propertyName] = ToArray((JArray)propertyValuePairs[propertyName]));
    }

    public static object[] ToArray(this JArray array)
    {
        return array.ToObject<object[]>().Select(ProcessArrayEntry).ToArray();
    }

    private static object ProcessArrayEntry(object value)
    {
        if (value is JObject)
        {
            return ToDictionary((JObject)value);
        }
        if (value is JArray)
        {
            return ToArray((JArray)value);
        }
        return value;
    }
}

