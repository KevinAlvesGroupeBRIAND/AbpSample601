using AbpSample601.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpSample601.Permissions;

public class AbpSample601PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpSample601Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpSample601Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpSample601Resource>(name);
    }
}
