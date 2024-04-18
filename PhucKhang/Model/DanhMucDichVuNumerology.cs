using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucDichVuNumerology
    {
        public int Id { get; set; }
        public string MaGoiDichVu { get; set; } = null!;
        public string? TenGoiDichVu { get; set; }
        public decimal NgaySuDung { get; set; }
        public decimal? GiaTien { get; set; }
    }
}
