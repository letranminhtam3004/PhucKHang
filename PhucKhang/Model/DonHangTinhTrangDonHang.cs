using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DonHangTinhTrangDonHang
    {
        public decimal IddonHang { get; set; }
        public short IdtrangThaiDonHang { get; set; }
        public string? GhiChu { get; set; }
        public decimal? IdnguoiXuLy { get; set; }
        public DateTime? NgayXuLy { get; set; }
    }
}
