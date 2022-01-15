using Remi.NutritionChecker.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Remi.NutritionChecker.Permissions;

public class NutritionCheckerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NutritionCheckerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NutritionCheckerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NutritionCheckerResource>(name);
    }
}
