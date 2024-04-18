using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class BaiViet
    {
        public decimal IdbaiViet { get; set; }
        public string? UrlhinhDaiDien { get; set; }
        public string? TieuDe { get; set; }
        public string? NoiDung { get; set; }
        public decimal? IdnguoiDang { get; set; }
        public short? IdchuyenMuc { get; set; }
        public string? LienHe { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public DateTime? NgayDang { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public byte TaoStickyTrangChu { get; set; }
        public string? StickyStyle { get; set; }
    }
}
