using System;
using System.Collections.Generic;
using System.Text;
using RaptUx.Localization;
using Volo.Abp.Application.Services;

namespace RaptUx;

/* Inherit your application services from this class.
 */
public abstract class RaptUxAppService : ApplicationService
{
    protected RaptUxAppService()
    {
        LocalizationResource = typeof(RaptUxResource);
    }
}
