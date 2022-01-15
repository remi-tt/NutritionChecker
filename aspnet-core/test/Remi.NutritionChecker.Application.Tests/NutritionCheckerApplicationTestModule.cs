using Volo.Abp.Modularity;

namespace Remi.NutritionChecker;

[DependsOn(
    typeof(NutritionCheckerApplicationModule),
    typeof(NutritionCheckerDomainTestModule)
    )]
public class NutritionCheckerApplicationTestModule : AbpModule
{

}
