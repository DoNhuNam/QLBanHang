using Volo.Abp.Modularity;

namespace QLBanHang.SanPham;

[DependsOn(
    typeof(SanPhamApplicationModule),
    typeof(SanPhamDomainTestModule)
    )]
public class SanPhamApplicationTestModule : AbpModule
{

}
