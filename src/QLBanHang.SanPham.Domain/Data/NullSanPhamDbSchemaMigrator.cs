using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QLBanHang.SanPham.Data;

/* This is used if database provider does't define
 * ISanPhamDbSchemaMigrator implementation.
 */
public class NullSanPhamDbSchemaMigrator : ISanPhamDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
