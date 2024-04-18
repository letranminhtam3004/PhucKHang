using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucTinhTrangDonHang
    {
        public string IdtinhTrangDonHang { get; set; } = null!;
        public string? MoTa { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public string? Code { get; set; }
        public byte? KhachHangDuocHuy { get; set; }
        public byte? NoiBoDuocHuy { get; set; }
        public byte? LoaiTrangThai { get; set; }
    }
}
