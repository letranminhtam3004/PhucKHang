using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucDichVuCongThem
    {
        public short IddichVuCongThem { get; set; }
        public string? MaDichVuCongThem { get; set; }
        public string? TenDichVuCongThem { get; set; }
        public double? GiaTien { get; set; }
        public byte? GiaCoDinh { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
