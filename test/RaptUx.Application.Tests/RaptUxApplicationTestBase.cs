using Volo.Abp.Modularity;

namespace RaptUx;

public abstract class RaptUxApplicationTestBase<TStartupModule> : RaptUxTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
