using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class SanPhamNhapXuat
    {
        public decimal Id { get; set; }
        public decimal IdsanPham { get; set; }
        /// <summary>
        /// 0: Xuất; 1: Nhập
        /// </summary>
        public byte Loai { get; set; }
        public short? SoLuong { get; set; }
        public decimal? IdnguoiNhap { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
