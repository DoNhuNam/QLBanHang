using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace QLBanHang.SanPham.Entities
{
    public class SanPham : Entity<int>
    {
        public SanPham()
        {
            AnhSanPhams = new List<AnhSanPham>();
        }
        public SanPham(int id) : base(id)
        {
            AnhSanPhams = new List<AnhSanPham>();
        }

        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public double? Gia { get; set; }

        public int HangId { get; set; }
        public Hang Hang { get; set; }
        public string QuocGiaId { get; set; }
        public QuocGia QuocGia { get; set; }

        public List<AnhSanPham> AnhSanPhams { get; set; }
    }
}
