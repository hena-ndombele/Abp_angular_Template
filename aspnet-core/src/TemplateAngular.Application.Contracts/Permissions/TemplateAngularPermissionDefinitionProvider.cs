using TemplateAngular.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TemplateAngular.Permissions;

public class TemplateAngularPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TemplateAngularPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TemplateAngularPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TemplateAngularResource>(name);
    }
}
