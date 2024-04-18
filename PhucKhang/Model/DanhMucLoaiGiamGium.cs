using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucLoaiGiamGium
    {
        public string MaLoaiGiamGia { get; set; } = null!;
        public string? TenLoaiGiamGia { get; set; }
        public DateTime NgayHeThong { get; set; }
    }
}
