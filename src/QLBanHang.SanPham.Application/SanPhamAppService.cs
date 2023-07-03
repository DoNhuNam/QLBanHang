using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.SanPham.Localization;
using Volo.Abp.Application.Services;

namespace QLBanHang.SanPham;

/* Inherit your application services from this class.
 */
public abstract class SanPhamAppService : ApplicationService
{
    protected SanPhamAppService()
    {
        LocalizationResource = typeof(SanPhamResource);
    }
}
