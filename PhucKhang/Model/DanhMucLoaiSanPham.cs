using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucLoaiSanPham
    {
        public short IdloaiSanPham { get; set; }
        public string TenLoaiSanPham { get; set; } = null!;
        public DateTime NgayHeThong { get; set; }
    }
}
