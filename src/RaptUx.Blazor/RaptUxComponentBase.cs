using RaptUx.Localization;
using Volo.Abp.AspNetCore.Components;

namespace RaptUx.Blazor;

public abstract class RaptUxComponentBase : AbpComponentBase
{
    protected RaptUxComponentBase()
    {
        LocalizationResource = typeof(RaptUxResource);
    }
}
