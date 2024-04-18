using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class ZThongSoKetNoi
    {
        public string MaThongSo { get; set; } = null!;
        public string? MaKetNoi { get; set; }
        public short? Loai { get; set; }
        public string? UserHost { get; set; }
        public string? Auth { get; set; }
    }
}
