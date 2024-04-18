using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucLoaiThe
    {
        public short IdloaiThe { get; set; }
        public string MaLoaiThe { get; set; } = null!;
        public string TenLoaiThe { get; set; } = null!;
        public double? SoTienToiThieu { get; set; }
        public double? SoTienToiDa { get; set; }
        public string? MaMau { get; set; }
        public string? MaDauThe { get; set; }
        public DateTime NgayHeThong { get; set; }
    }
}
