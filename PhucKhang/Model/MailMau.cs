using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class MailMau
    {
        public decimal IdmailMau { get; set; }
        public string? MoTa { get; set; }
        public string? TieuDe { get; set; }
        public string? NoiDung { get; set; }
        public decimal? IdnguoiThem { get; set; }
        public DateTime? NgayHeThong { get; set; }
        public string? LoaiMail { get; set; }
    }
}
