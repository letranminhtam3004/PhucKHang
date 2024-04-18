using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class CuaHang
    {
        public decimal IdcuaHang { get; set; }
        /// <summary>
        /// La duy nhat
        /// </summary>
        public string? MaCuaHang { get; set; }
        public string? TenCuaHang { get; set; }
        public string? Urllogo { get; set; }
        public string? DiaChiCuaHang { get; set; }
        public string? DienThoaiCuaHang { get; set; }
        public string? EmailCuaHang { get; set; }
        public string? TenNguoiDaiDienCuaHang { get; set; }
        public string? DiaChiWebCuaHang { get; set; }
        public decimal? IdcuaHangCha { get; set; }
        public short? CapDoCuaHang { get; set; }
        public string? ThanhPho { get; set; }
        public string? MaBang { get; set; }
        public string? MaQuocGia { get; set; }
        public string? TenBang { get; set; }
        public string? TenQuocGia { get; set; }
        public string? TenQuan { get; set; }
    }
}
