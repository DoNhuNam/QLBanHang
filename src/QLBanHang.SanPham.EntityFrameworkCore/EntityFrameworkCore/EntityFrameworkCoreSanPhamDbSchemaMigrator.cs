using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLBanHang.SanPham.Data;
using Volo.Abp.DependencyInjection;

namespace QLBanHang.SanPham.EntityFrameworkCore;

public class EntityFrameworkCoreSanPhamDbSchemaMigrator
    : ISanPhamDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSanPhamDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SanPhamDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SanPhamDbContext>()
            .Database
            .MigrateAsync();
    }
}
