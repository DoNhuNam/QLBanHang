using System.Threading.Tasks;

namespace QLBanHang.SanPham.Data;

public interface ISanPhamDbSchemaMigrator
{
    Task MigrateAsync();
}
