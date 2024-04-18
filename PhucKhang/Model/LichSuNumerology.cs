using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class LichSuNumerology
    {
        public int Id { get; set; }
        public string IgenCode { get; set; } = null!;
        public string HoTen { get; set; } = null!;
        public DateTime SinhNhat { get; set; }
        public string Email { get; set; } = null!;
        public string? NgaySinh { get; set; }
        public string? DuongDoi { get; set; }
        public string? SuMenh { get; set; }
        public string? KetNoiDuongDoiSuMenh { get; set; }
        public string? CanBang { get; set; }
        public string? LinhHon { get; set; }
        public string? NhanCach { get; set; }
        public string? KetNoiLinhHonNhanCach { get; set; }
        public string? TruongThanh { get; set; }
        public string? Thieu { get; set; }
        public string? TuDuyLyTri { get; set; }
        public string? SucManhTiemThuc { get; set; }
        public string? DamMe { get; set; }
        public string? Chan { get; set; }
        public string? ThachThuc { get; set; }
        public string? Nam { get; set; }
        public string? Thang { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public string? HoTenGoc { get; set; }
        public string? SoCungMenh { get; set; }
        public string? GioiTinh { get; set; }
        public string? Ngay { get; set; }
        public int? IdnguoiTao { get; set; }
    }
}
