using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace RaptUx.Blazor;

[Dependency(ReplaceServices = true)]
public class RaptUxBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RaptUx";
}
