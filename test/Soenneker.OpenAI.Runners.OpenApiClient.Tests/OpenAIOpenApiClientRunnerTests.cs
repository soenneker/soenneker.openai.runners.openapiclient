using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenAI.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenAIOpenApiClientRunnerTests : HostedUnitTest
{
    public OpenAIOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
