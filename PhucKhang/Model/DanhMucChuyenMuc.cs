using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucChuyenMuc
    {
        public short IdchuyenMuc { get; set; }
        public string MaChuyenMuc { get; set; } = null!;
        public string TenChuyenMuc { get; set; } = null!;
        public string? LoaiChuyenMuc { get; set; }
        public byte CapDoChuyenMuc { get; set; }
        public string? Thuoc { get; set; }
        public int? MinWidthScreen { get; set; }
        public DateTime NgayHeThong { get; set; }
    }
}
