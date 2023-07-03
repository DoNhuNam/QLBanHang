using QLBanHang.SanPham.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace QLBanHang.SanPham.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SanPhamEntityFrameworkCoreModule),
    typeof(SanPhamApplicationContractsModule)
    )]
public class SanPhamDbMigratorModule : AbpModule
{

}
