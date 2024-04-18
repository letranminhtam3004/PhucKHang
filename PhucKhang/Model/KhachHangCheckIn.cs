using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class KhachHangCheckIn
    {
        public decimal Id { get; set; }
        public string? Ho { get; set; }
        public string? Ten { get; set; }
        public string? DienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? TraLoiKhaoSat { get; set; }
        public short? Idgoi { get; set; }
        public string? TenGoi { get; set; }
        public byte? XacNhan { get; set; }
        public string? UserNguoiXacNhan { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? NgayXemDuKien { get; set; }
    }
}
