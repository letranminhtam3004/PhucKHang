using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class KhachHang
    {
        public decimal IdkhachHang { get; set; }
        public decimal? IdloaiThe { get; set; }
        public string? MaThe { get; set; }
        public string? DanhXung { get; set; }
        public string? Ho { get; set; }
        public string? Ten { get; set; }
        public string DienThoai { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? ThanhPho { get; set; }
        public string? MaBang { get; set; }
        public string? MaQuocGia { get; set; }
        public string? TenQuocGia { get; set; }
        public string? TenBang { get; set; }
        public string? TenQuan { get; set; }
        public string? Email { get; set; }
        public string? Cmnd { get; set; }
        public DateTime? NgaySinhNhat { get; set; }
        public byte? GhiNo { get; set; }
        public byte? NhanEmail { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public byte? Isuse { get; set; }
        public int? GioiTinh { get; set; }
    }
}
