using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace QLBanHang.SanPham;

public class SanPhamWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<SanPhamWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
