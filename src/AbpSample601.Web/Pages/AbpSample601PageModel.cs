using AbpSample601.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpSample601.Web.Pages;

public abstract class AbpSample601PageModel : AbpPageModel
{
    protected AbpSample601PageModel()
    {
        LocalizationResourceType = typeof(AbpSample601Resource);
    }
}
