using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class SanPhamYeuThich
    {
        public decimal Id { get; set; }
        public decimal IdsanPham { get; set; }
        /// <summary>
        /// 0: Xuất; 1: Nhập
        /// </summary>
        public short YeuThich { get; set; }
        public decimal? IdnguoiNhap { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
