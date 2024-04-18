using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class ChiPhi
    {
        public decimal IdchiPhi { get; set; }
        public DateTime? NgayPhatSinh { get; set; }
        public decimal? SoTien { get; set; }
        public string? GhiChu { get; set; }
        public decimal? IdnguoiNhap { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public short? IdloaiChiPhi { get; set; }
    }
}
