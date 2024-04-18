using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class NguoiDung
    {
        public decimal IdnguoiDung { get; set; }
        public string? TaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public string? Ho { get; set; }
        public string? Ten { get; set; }
        public string DienThoai { get; set; } = null!;
        public string? Email { get; set; }
        public string? Cmnd { get; set; }
        public DateTime? NgaySinhNhat { get; set; }
        public byte? IdvaiTro { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public decimal? IdcuaHang { get; set; }
        public decimal? IdkhachHang { get; set; }
        public byte? IsLock { get; set; }
        public string? Token { get; set; }
        public string? ChuDe { get; set; }
    }
}
