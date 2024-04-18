using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucLoaiChiPhi
    {
        public short IdloaiChiPhi { get; set; }
        public string TenLoaiChiPhi { get; set; } = null!;
        public DateTime NgayHeThong { get; set; }
    }
}
