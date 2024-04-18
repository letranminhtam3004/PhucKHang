using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucNhaVanChuyen
    {
        public int Id { get; set; }
        public string MaNhaVanChuyen { get; set; } = null!;
        public decimal? GiaToiThieuNoiTinh { get; set; }
        public decimal? GiaToiThieuLienTinh { get; set; }
        public string TypeUrl { get; set; } = null!;
        public string? MoTa { get; set; }
        public string? Url { get; set; }
        public string? Token { get; set; }
        public string? ContentType { get; set; }
        public string? TokenIn { get; set; }
        public decimal? ShopId { get; set; }
        public byte? IsEdit { get; set; }
        public byte? IsUse { get; set; }
        public string? MaBangHoTro { get; set; }
        public DateTime NgayHeThong { get; set; }
        public short? SoThuTu { get; set; }
    }
}
