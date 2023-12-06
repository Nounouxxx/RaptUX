using RaptUx.Samples;
using Xunit;

namespace RaptUx.EntityFrameworkCore.Applications;

[Collection(RaptUxTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<RaptUxEntityFrameworkCoreTestModule>
{

}
