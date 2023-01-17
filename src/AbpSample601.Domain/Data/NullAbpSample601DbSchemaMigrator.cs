using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpSample601.Data;

/* This is used if database provider does't define
 * IAbpSample601DbSchemaMigrator implementation.
 */
public class NullAbpSample601DbSchemaMigrator : IAbpSample601DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
