using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucHinhThucThanhToan
    {
        public short IdhinhThucThanhToan { get; set; }
        public string? TenHinhThucThanhToan { get; set; }
        public byte? SuDungCongCong { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
