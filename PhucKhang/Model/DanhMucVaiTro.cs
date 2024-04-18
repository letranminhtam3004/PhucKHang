using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucVaiTro
    {
        public int IdvaiTro { get; set; }
        public string? MoTa { get; set; }
        public byte? CapDoQuanLy { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
