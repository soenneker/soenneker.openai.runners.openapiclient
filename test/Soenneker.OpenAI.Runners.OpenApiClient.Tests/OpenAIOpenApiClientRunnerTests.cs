using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenAI.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenAIOpenApiClientRunnerTests : FixturedUnitTest
{
    public OpenAIOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
