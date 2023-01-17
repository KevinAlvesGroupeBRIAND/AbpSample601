using System.Threading.Tasks;

namespace AbpSample601.Data;

public interface IAbpSample601DbSchemaMigrator
{
    Task MigrateAsync();
}
