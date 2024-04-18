using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucChiTietDichVuCongThem
    {
        public int IdchiTietDichVuCongThem { get; set; }
        public string? MaDichVuCongThem { get; set; }
        public string? TenChiTietDichVuCongThem { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
