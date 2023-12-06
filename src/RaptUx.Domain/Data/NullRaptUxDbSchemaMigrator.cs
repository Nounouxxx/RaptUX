using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RaptUx.Data;

/* This is used if database provider does't define
 * IRaptUxDbSchemaMigrator implementation.
 */
public class NullRaptUxDbSchemaMigrator : IRaptUxDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
