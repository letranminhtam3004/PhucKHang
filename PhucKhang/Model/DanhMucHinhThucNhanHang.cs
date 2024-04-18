using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucHinhThucNhanHang
    {
        public short IdhinhThucNhanHang { get; set; }
        public string? TenHinhThucNhanHang { get; set; }
        public string? SvgHinhThuc { get; set; }
        public byte? SuDungCongCong { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
