using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class MaGiamGium
    {
        public string MaGiamGia { get; set; } = null!;
        public string LoaiGiamGia { get; set; } = null!;
        public int? SoTienGiamGia { get; set; }
        public double? TyLeGiamGia { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public short SoLanSuDung { get; set; }
        public byte? NoiBo { get; set; }
        public DateTime? NgayHeThong { get; set; }
    }
}
