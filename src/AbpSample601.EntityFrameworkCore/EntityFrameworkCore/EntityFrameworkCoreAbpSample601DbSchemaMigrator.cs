using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpSample601.Data;
using Volo.Abp.DependencyInjection;

namespace AbpSample601.EntityFrameworkCore;

public class EntityFrameworkCoreAbpSample601DbSchemaMigrator
    : IAbpSample601DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpSample601DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpSample601DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpSample601DbContext>()
            .Database
            .MigrateAsync();
    }
}
