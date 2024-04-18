using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucDonViTinh
    {
        public short IddonViTinh { get; set; }
        public string TenDonViTinh { get; set; } = null!;
        public DateTime NgayHeThong { get; set; }
    }
}
