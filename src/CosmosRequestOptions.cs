using Microsoft.Azure.Cosmos;

namespace Soenneker.Cosmos.RequestOptions;

/// <summary>
/// Provides predefined request options for Cosmos DB operations.
/// </summary>
public static class CosmosRequestOptions
{
    /// <summary>
    /// Specifies an <see cref="ItemRequestOptions"/> instance that disables content response on write operations.
    /// </summary>
    public static readonly ItemRequestOptions ExcludeResponse = new()
    {
        EnableContentResponseOnWrite = false
    };

    /// <summary>
    /// Specifies a <see cref="QueryRequestOptions"/> instance that limits the maximum item count per query request to one.
    /// </summary>
    public static readonly QueryRequestOptions MaxItemCountOne = new()
    {
        MaxItemCount = 1
    };
}