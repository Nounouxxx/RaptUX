using RaptUx.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RaptUx.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RaptUxController : AbpControllerBase
{
    protected RaptUxController()
    {
        LocalizationResource = typeof(RaptUxResource);
    }
}
