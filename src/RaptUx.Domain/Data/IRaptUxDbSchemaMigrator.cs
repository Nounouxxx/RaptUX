using System.Threading.Tasks;

namespace RaptUx.Data;

public interface IRaptUxDbSchemaMigrator
{
    Task MigrateAsync();
}
