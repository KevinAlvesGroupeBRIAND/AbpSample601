using AbpSample601.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpSample601;

[DependsOn(
    typeof(AbpSample601EntityFrameworkCoreTestModule)
    )]
public class AbpSample601DomainTestModule : AbpModule
{

}
