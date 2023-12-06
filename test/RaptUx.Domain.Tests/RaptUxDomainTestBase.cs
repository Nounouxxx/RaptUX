using Volo.Abp.Modularity;

namespace RaptUx;

/* Inherit from this class for your domain layer tests. */
public abstract class RaptUxDomainTestBase<TStartupModule> : RaptUxTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
