using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class KhachHangNumerology
    {
        public decimal IdnguoiDung { get; set; }
        public string? MaGoiDichVu { get; set; }
        public decimal IdnguoiCapQuyen { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
