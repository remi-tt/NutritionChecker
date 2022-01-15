using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Remi.NutritionChecker;

[Dependency(ReplaceServices = true)]
public class NutritionCheckerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NutritionChecker";
}
