using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucBaoCao
    {
        public short IdbaoCao { get; set; }
        public short? ViTri { get; set; }
        public string TenBaoCao { get; set; } = null!;
        public string? CotBaoCao { get; set; }
        public string? SumBaoCao { get; set; }
        public byte? IsUse { get; set; }
        public DateTime NgayHeThong { get; set; }
    }
}
