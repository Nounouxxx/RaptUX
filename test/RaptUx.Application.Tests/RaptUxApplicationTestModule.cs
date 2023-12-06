using Volo.Abp.Modularity;

namespace RaptUx;

[DependsOn(
    typeof(RaptUxApplicationModule),
    typeof(RaptUxDomainTestModule)
)]
public class RaptUxApplicationTestModule : AbpModule
{

}
