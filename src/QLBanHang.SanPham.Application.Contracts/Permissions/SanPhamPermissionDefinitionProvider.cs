using QLBanHang.SanPham.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QLBanHang.SanPham.Permissions;

public class SanPhamPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SanPhamPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SanPhamPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SanPhamResource>(name);
    }
}
