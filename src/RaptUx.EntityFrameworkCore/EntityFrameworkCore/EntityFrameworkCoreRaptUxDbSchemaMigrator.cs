using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RaptUx.Data;
using Volo.Abp.DependencyInjection;

namespace RaptUx.EntityFrameworkCore;

public class EntityFrameworkCoreRaptUxDbSchemaMigrator
    : IRaptUxDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRaptUxDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the RaptUxDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RaptUxDbContext>()
            .Database
            .MigrateAsync();
    }
}
