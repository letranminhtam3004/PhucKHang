using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class LogGuiVanDon
    {
        public int Id { get; set; }
        public string? NhaVanChuyen { get; set; }
        public string? MaDonHang { get; set; }
        public string? MaVanDon { get; set; }
        public string? MaInNhan { get; set; }
        public decimal? TongPhiShip { get; set; }
        public string? TenCuaHang { get; set; }
        public string? DiaChiCuaHang { get; set; }
        public string? TenTinhGui { get; set; }
        public string? TenHuyenGui { get; set; }
        public string? TenXaGui { get; set; }
        public string? DienThoaiGui { get; set; }
        public string? HoTenNguoiNhan { get; set; }
        public string? DienThoaiNguoiNhan { get; set; }
        public string? DiaChiNhan { get; set; }
        public string? TenTinhNhan { get; set; }
        public string? TenHuyenNhan { get; set; }
        public string? TenXaNhan { get; set; }
        public string? DiaChiCap4 { get; set; }
        public decimal? TongKhoiLuong { get; set; }
        public bool? MienShip { get; set; }
        public DateTime? NgayGiao { get; set; }
        public decimal? ThuHo { get; set; }
        public decimal? KhaiGia { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
