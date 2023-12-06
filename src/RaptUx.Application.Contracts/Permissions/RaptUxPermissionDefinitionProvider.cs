using RaptUx.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RaptUx.Permissions;

public class RaptUxPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RaptUxPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RaptUxPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RaptUxResource>(name);
    }
}
