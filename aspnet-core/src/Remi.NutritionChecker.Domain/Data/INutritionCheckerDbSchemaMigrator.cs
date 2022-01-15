using System.Threading.Tasks;

namespace Remi.NutritionChecker.Data;

public interface INutritionCheckerDbSchemaMigrator
{
    Task MigrateAsync();
}
