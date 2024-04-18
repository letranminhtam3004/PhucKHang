using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class SanPham
    {
        public decimal IdsanPham { get; set; }
        public string? MaSanPham { get; set; }
        /// <summary>
        /// gram
        /// </summary>
        public int? KhoiLuong { get; set; }
        /// <summary>
        /// milimet
        /// </summary>
        public int? Dai { get; set; }
        /// <summary>
        /// milimet
        /// </summary>
        public int? Rong { get; set; }
        /// <summary>
        /// milimet
        /// </summary>
        public int? Cao { get; set; }
        public string? TenSanPham { get; set; }
        public decimal? TriGia { get; set; }
        public decimal? GiaBan { get; set; }
        public string? GiaTriTienTe { get; set; }
        public double? GiamGia { get; set; }
        public string? MoTa { get; set; }
        public short? SoLuong { get; set; }
        /// <summary>
        /// Ngày bắt đầu bảo hành, Ngày sản xuất
        /// </summary>
        public DateTime? NgaySanXuat { get; set; }
        /// <summary>
        /// Ngày kết thúc bảo hành, Ngày hết hạn sản phẩm
        /// </summary>
        public DateTime? NgayHetHan { get; set; }
        /// <summary>
        /// tính theo tháng
        /// </summary>
        public short? ThoiGianBaoHanh { get; set; }
        public decimal? IdcuaHang { get; set; }
        public short? IddonViTinh { get; set; }
        public DateTime? NgayTaoDauTien { get; set; }
        public decimal? GiaSauGiam { get; set; }
        public decimal? IdnguoiNhap { get; set; }
        public byte SanPhamTrucTuyen { get; set; }
    }
}
