using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cosmos.RequestOptions.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CosmosRequestOptionsTests : HostedUnitTest
{
    public CosmosRequestOptionsTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
