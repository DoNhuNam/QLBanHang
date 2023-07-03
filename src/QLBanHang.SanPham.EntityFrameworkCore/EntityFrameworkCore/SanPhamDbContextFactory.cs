using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QLBanHang.SanPham.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SanPhamDbContextFactory : IDesignTimeDbContextFactory<SanPhamDbContext>
{
    public SanPhamDbContext CreateDbContext(string[] args)
    {
        SanPhamEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SanPhamDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SanPhamDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../QLBanHang.SanPham.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
