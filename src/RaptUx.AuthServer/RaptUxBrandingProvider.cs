using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RaptUx;

[Dependency(ReplaceServices = true)]
public class RaptUxBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RaptUx";
}
