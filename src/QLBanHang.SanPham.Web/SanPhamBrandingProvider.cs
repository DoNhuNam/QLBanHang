using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace QLBanHang.SanPham.Web;

[Dependency(ReplaceServices = true)]
public class SanPhamBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SanPham";
}
