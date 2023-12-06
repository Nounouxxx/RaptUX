using Volo.Abp.Modularity;

namespace RaptUx;

[DependsOn(
    typeof(RaptUxDomainModule),
    typeof(RaptUxTestBaseModule)
)]
public class RaptUxDomainTestModule : AbpModule
{

}
