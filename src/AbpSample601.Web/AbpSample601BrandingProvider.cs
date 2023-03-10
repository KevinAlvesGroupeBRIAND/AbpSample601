using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpSample601.Web;

[Dependency(ReplaceServices = true)]
public class AbpSample601BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpSample601";
}
