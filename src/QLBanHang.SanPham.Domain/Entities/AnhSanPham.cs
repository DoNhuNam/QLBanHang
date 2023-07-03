using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace QLBanHang.SanPham.Entities
{
    public class AnhSanPham : Entity<int>
    {
        public AnhSanPham() { }
        public AnhSanPham(int id) : base(id) { }
        public string Url { get; set; }
        public string MoTa { get; set; }
        public int? SapXep { get; set; }
        public int SanPhamId { get; set; }
        public SanPham SanPham { get; set; }
    }
}
