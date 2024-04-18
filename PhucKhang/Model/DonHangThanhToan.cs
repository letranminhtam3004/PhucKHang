using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DonHangThanhToan
    {
        public int Id { get; set; }
        public string? MaDoiTac { get; set; }
        public string MaDonHang { get; set; } = null!;
        public string? TrangThaiThanhToan { get; set; }
        public string? MaThanhToan { get; set; }
        public string? ChuKy { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? NgayTrangThai { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public decimal? TongThanhToan { get; set; }
        public string? MaThamChieu { get; set; }
        public int? LanThanhToan { get; set; }
    }
}
