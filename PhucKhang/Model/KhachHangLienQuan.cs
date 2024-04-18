using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class KhachHangLienQuan
    {
        public string IdkhachHangLienQuan { get; set; } = null!;
        public int IdkhachHang { get; set; }
        public string? MoiQuanHe { get; set; }
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
        public string? DienThoai { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
