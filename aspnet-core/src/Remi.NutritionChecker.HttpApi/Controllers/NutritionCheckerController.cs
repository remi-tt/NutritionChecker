using Remi.NutritionChecker.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Remi.NutritionChecker.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NutritionCheckerController : AbpControllerBase
{
    protected NutritionCheckerController()
    {
        LocalizationResource = typeof(NutritionCheckerResource);
    }
}
