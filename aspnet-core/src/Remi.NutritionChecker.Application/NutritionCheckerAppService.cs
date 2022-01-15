using System;
using System.Collections.Generic;
using System.Text;
using Remi.NutritionChecker.Localization;
using Volo.Abp.Application.Services;

namespace Remi.NutritionChecker;

/* Inherit your application services from this class.
 */
public abstract class NutritionCheckerAppService : ApplicationService
{
    protected NutritionCheckerAppService()
    {
        LocalizationResource = typeof(NutritionCheckerResource);
    }
}
