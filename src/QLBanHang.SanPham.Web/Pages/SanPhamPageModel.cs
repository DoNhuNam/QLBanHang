using QLBanHang.SanPham.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QLBanHang.SanPham.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SanPhamPageModel : AbpPageModel
{
    protected SanPhamPageModel()
    {
        LocalizationResourceType = typeof(SanPhamResource);
    }
}
