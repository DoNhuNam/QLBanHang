using QLBanHang.SanPham.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QLBanHang.SanPham;

[DependsOn(
    typeof(SanPhamEntityFrameworkCoreTestModule)
    )]
public class SanPhamDomainTestModule : AbpModule
{

}
