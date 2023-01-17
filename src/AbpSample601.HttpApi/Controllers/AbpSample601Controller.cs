using AbpSample601.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSample601.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpSample601Controller : AbpControllerBase
{
    protected AbpSample601Controller()
    {
        LocalizationResource = typeof(AbpSample601Resource);
    }
}
