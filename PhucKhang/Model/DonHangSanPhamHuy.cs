using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DonHangSanPhamHuy
    {
        public decimal IddonHang { get; set; }
        public decimal IdsanPham { get; set; }
        public short? SoLuong { get; set; }
        public decimal? ThanhTien { get; set; }
        public DateTime? NgayBatDauBaoHanh { get; set; }
        public DateTime? NgayHetHanBaoHanh { get; set; }
        public decimal? IdnguoiXacNhan { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
