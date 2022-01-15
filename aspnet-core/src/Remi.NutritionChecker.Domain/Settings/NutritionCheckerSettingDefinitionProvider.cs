using Volo.Abp.Settings;

namespace Remi.NutritionChecker.Settings;

public class NutritionCheckerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NutritionCheckerSettings.MySetting1));
    }
}
