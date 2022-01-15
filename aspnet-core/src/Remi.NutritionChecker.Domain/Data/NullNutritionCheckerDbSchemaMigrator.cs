using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Remi.NutritionChecker.Data;

/* This is used if database provider does't define
 * INutritionCheckerDbSchemaMigrator implementation.
 */
public class NullNutritionCheckerDbSchemaMigrator : INutritionCheckerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
