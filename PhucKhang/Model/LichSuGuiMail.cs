using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class LichSuGuiMail
    {
        public decimal IdlichSuGuiMail { get; set; }
        public decimal? IdkhachHang { get; set; }
        public string? LoaiMail { get; set; }
        public string? NgaySinhNhat { get; set; }
        public string? TieuDe { get; set; }
        public string? NoiDung { get; set; }
        public string? DiaChiMailNguoiNhan { get; set; }
        public decimal? IdnguoiXuLy { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
