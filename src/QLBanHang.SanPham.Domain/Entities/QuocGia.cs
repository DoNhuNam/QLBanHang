using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace QLBanHang.SanPham.Entities
{
    public class QuocGia : Entity<string>
    {
        public QuocGia()
        {
            SanPhams = new List<SanPham>();
        }
        public QuocGia(string id) : base(id)
        {
            SanPhams = new List<SanPham>();
        }
        public string TenQuocGia { get; set; }
        public List<SanPham> SanPhams { get; set; }
    }
}
