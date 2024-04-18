using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DonHangDichVuCongThem
    {
        public decimal IddonHang { get; set; }
        public short IddichVuCongThem { get; set; }
        public int? SoLuong { get; set; }
        public int? ThanhTien { get; set; }
        public string? IdchiTietDichVuCongThem { get; set; }
    }
}
