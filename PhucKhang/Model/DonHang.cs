using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DonHang
    {
        public decimal IddonHang { get; set; }
        public string MaDonHang { get; set; } = null!;
        public string? MaDonChung { get; set; }
        /// <summary>
        /// = IDNguoiDung la nhan vien cua hang
        /// </summary>
        public decimal? IdnguoiTaoDon { get; set; }
        /// <summary>
        /// = IDNguoiDung neu la khach hang cu
        /// </summary>
        public decimal? IdkhachHang { get; set; }
        public string? HoTenNguoiNhan { get; set; }
        public string? DiaChiNhan { get; set; }
        public string? ThanhPhoNhan { get; set; }
        public string? MaBangNhan { get; set; }
        public string? TenQuocGiaNhan { get; set; }
        public string? MaQuocGiaNhan { get; set; }
        public string? TenBangNhan { get; set; }
        public string? TenQuanNhan { get; set; }
        public string? DienThoaiKhachHang { get; set; }
        /// <summary>
        /// Dien thoai nguoi lien lac nhan hang
        /// </summary>
        public string? DienThoaiNguoiNhan { get; set; }
        public byte? HinhThucNhanHang { get; set; }
        public byte? HinhThucThanhToan { get; set; }
        public string? GhiChu { get; set; }
        public short? TongSoLuong { get; set; }
        public decimal? TongSoTien { get; set; }
        public decimal? TongTienDichVuCongThem { get; set; }
        public decimal? Vat { get; set; }
        public string? MaGiamGia { get; set; }
        public decimal? SoTienGiam { get; set; }
        public decimal? PhiShip { get; set; }
        public decimal? TongSoTienThanhToan { get; set; }
        /// <summary>
        /// = IDNguoiDung neu co thay doi thong tin don hang
        /// </summary>
        public decimal? IdnguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public DateTime? NgayGiaoHangDuKien { get; set; }
        public decimal? SoTienGiamTrenSanPham { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public int? IdtrangThaiHienTai { get; set; }
        public string? LoaiDonHang { get; set; }
    }
}
