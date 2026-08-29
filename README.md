[![](https://img.shields.io/nuget/v/soenneker.cosmos.requestoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cosmos.requestoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cosmos.requestoptions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cosmos.requestoptions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cosmos.requestoptions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cosmos.requestoptions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cosmos.requestoptions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cosmos.requestoptions/actions/workflows/codeql.yml)

# Soenneker.Cosmos.RequestOptions

Provides predefined request options for Cosmos DB operations.

## Install

```bash
dotnet add package Soenneker.Cosmos.RequestOptions
```

## What you get

- `CosmosRequestOptions` — Provides predefined request options for Cosmos DB operations.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `CosmosRequestOptions.ExcludeResponse` | Specifies an `ItemRequestOptions` instance that disables content response on write operations. | Specifies an `ItemRequestOptions` instance that disables content response on write operations. |
| `CosmosRequestOptions.MaxItemCountOne` | Specifies a `QueryRequestOptions` instance that limits the maximum item count per query request to one. | Specifies a `QueryRequestOptions` instance that limits the maximum item count per query request to one. |
