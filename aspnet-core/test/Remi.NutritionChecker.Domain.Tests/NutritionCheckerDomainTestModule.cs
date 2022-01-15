using Remi.NutritionChecker.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Remi.NutritionChecker;

[DependsOn(
    typeof(NutritionCheckerEntityFrameworkCoreTestModule)
    )]
public class NutritionCheckerDomainTestModule : AbpModule
{

}
