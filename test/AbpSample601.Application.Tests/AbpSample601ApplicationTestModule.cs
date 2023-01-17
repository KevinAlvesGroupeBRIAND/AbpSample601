using Volo.Abp.Modularity;

namespace AbpSample601;

[DependsOn(
    typeof(AbpSample601ApplicationModule),
    typeof(AbpSample601DomainTestModule)
    )]
public class AbpSample601ApplicationTestModule : AbpModule
{

}
