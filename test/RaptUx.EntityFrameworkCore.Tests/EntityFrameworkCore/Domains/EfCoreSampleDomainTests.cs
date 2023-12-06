using RaptUx.Samples;
using Xunit;

namespace RaptUx.EntityFrameworkCore.Domains;

[Collection(RaptUxTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<RaptUxEntityFrameworkCoreTestModule>
{

}
