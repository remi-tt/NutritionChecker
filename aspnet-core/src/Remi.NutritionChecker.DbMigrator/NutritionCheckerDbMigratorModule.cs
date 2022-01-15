using Remi.NutritionChecker.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Remi.NutritionChecker.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NutritionCheckerEntityFrameworkCoreModule),
    typeof(NutritionCheckerApplicationContractsModule)
    )]
public class NutritionCheckerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
