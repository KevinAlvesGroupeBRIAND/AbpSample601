using System;
using System.Collections.Generic;
using System.Text;
using AbpSample601.Localization;
using Volo.Abp.Application.Services;

namespace AbpSample601;

/* Inherit your application services from this class.
 */
public abstract class AbpSample601AppService : ApplicationService
{
    protected AbpSample601AppService()
    {
        LocalizationResource = typeof(AbpSample601Resource);
    }
}
