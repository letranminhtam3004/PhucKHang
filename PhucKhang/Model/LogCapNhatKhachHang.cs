using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class LogCapNhatKhachHang
    {
        public int Id { get; set; }
        public int? IdnguoiThucHien { get; set; }
        public int? IdkhachHang { get; set; }
        public DateTime? NgaySinhCu { get; set; }
        public DateTime? NgaySinhMoi { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
