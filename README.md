[![](https://img.shields.io/nuget/v/soenneker.cosmos.requestoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cosmos.requestoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cosmos.requestoptions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cosmos.requestoptions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cosmos.requestoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cosmos.requestoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cosmos.requestoptions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cosmos.requestoptions/actions/workflows/codeql.yml)

# Soenneker.Cosmos.RequestOptions

Small factory properties for common Azure Cosmos DB request-option configurations.

## Installation

```bash
dotnet add package Soenneker.Cosmos.RequestOptions
```

## Suppress write response content

```csharp
ItemResponse<OrderDocument> response = await container.CreateItemAsync(
    order,
    new PartitionKey(order.PartitionKey),
    CosmosRequestOptions.ExcludeResponse,
    cancellationToken);
```

`ExcludeResponse` returns an `ItemRequestOptions` instance with `EnableContentResponseOnWrite = false`. This reduces response payload work when the caller does not need Cosmos to return the stored resource. The resulting `ItemResponse<T>.Resource` may be absent; keep using the document passed to the write when needed.

## Request one item per query page

```csharp
using FeedIterator<OrderDocument> iterator = container.GetItemQueryIterator<OrderDocument>(
    queryDefinition,
    requestOptions: CosmosRequestOptions.MaxItemCountOne);
```

`MaxItemCountOne` returns a `QueryRequestOptions` instance with `MaxItemCount = 1`. It limits the requested page size; it does not add `TOP 1` to the query or guarantee that Cosmos will produce exactly one item on every page.

Each property access returns a new mutable SDK options object, so callers can customize it without changing another request:

```csharp
QueryRequestOptions options = CosmosRequestOptions.MaxItemCountOne;
options.PartitionKey = new PartitionKey("tenant-42");
```

No dependency-injection registration or application configuration is required.
