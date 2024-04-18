using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucLoaiMail
    {
        public string MaLoaiMail { get; set; } = null!;
        public string TenLoaiMail { get; set; } = null!;
        public DateTime NgayHeThong { get; set; }
    }
}
