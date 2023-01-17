using AbpSample601.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpSample601.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpSample601EntityFrameworkCoreModule),
    typeof(AbpSample601ApplicationContractsModule)
    )]
public class AbpSample601DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
