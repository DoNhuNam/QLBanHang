using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace QLBanHang.SanPham.Pages;

public class Index_Tests : SanPhamWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
