using Volo.Abp.Settings;

namespace QLBanHang.SanPham.Settings;

public class SanPhamSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SanPhamSettings.MySetting1));
    }
}
