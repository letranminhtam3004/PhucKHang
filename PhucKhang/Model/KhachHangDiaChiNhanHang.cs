using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class KhachHangDiaChiNhanHang
    {
        public decimal IddiaChiNhanHang { get; set; }
        public decimal IdkhachHang { get; set; }
        public string? Ho { get; set; }
        public string? Ten { get; set; }
        public string DienThoai { get; set; } = null!;
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? MaBang { get; set; }
        public string? MaQuocGia { get; set; }
        public string? ThanhPho { get; set; }
        public string? TenQuocGia { get; set; }
        public bool? MacDinh { get; set; }
        public string? TenBang { get; set; }
        public string? TenQuan { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
