using HotChocolate.Execution;
using HotChocolate.Tests;
using Snapshooter;
using Snapshooter.Xunit;

namespace HotChocolate.Data.Sorting;

public static class TestExtensions
{
    public static void MatchSqlSnapshot(
        this IExecutionResult? result,
        string snapshotName)
    {
#if NET5_0
            const string postfix = "_NET5_0";
#elif NET6_0
        const string postfix = "_NET6_0";
#else
            const string postfix = "";
#endif
        if (result is { })
        {
            if (result.ContextData is { } &&
                result.ContextData.TryGetValue("sql", out var queryResult))
            {
                queryResult.MatchSnapshot(
                    new SnapshotNameExtension(snapshotName + "_sql" + postfix));
            }

            result.MatchSnapshot(snapshotName);
        }
    }
}