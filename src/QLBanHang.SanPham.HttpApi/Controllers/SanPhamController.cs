using QLBanHang.SanPham.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QLBanHang.SanPham.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SanPhamController : AbpControllerBase
{
    protected SanPhamController()
    {
        LocalizationResource = typeof(SanPhamResource);
    }
}
