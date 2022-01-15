using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Remi.NutritionChecker.Data;
using Volo.Abp.DependencyInjection;

namespace Remi.NutritionChecker.EntityFrameworkCore;

public class EntityFrameworkCoreNutritionCheckerDbSchemaMigrator
    : INutritionCheckerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNutritionCheckerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NutritionCheckerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NutritionCheckerDbContext>()
            .Database
            .MigrateAsync();
    }
}
