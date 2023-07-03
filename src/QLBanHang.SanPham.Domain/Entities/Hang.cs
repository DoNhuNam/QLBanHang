using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace QLBanHang.SanPham.Entities
{
    public class Hang : Entity<int>
    {
        public Hang()
        {
            SanPhams = new List<SanPham>();
        }
        public Hang(int id) : base(id)
        {
            SanPhams = new List<SanPham>();
        }
        public string TenHang { get; set; }
        public string MoTa { get; set; }
        public List<SanPham> SanPhams { get; set; }
    }
}
