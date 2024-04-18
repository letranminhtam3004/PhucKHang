using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class NguoiDungGioHang
    {
        public decimal IdnguoiDung { get; set; }
        public decimal IdsanPham { get; set; }
        public short SoLuong { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
