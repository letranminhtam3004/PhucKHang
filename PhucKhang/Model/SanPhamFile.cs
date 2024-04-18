using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class SanPhamFile
    {
        public decimal Id { get; set; }
        public decimal IdsanPham { get; set; }
        public string? UrlhinhAnh { get; set; }
        public string TenTapTin { get; set; } = null!;
        public DateTime? NgayHeThong { get; set; }
    }
}
