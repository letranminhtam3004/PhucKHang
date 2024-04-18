using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DoiTacThanhToanMomo
    {
        public int Id { get; set; }
        public string MaDoiTac { get; set; } = null!;
        public string? TenDoiTac { get; set; }
        public string? MomoUrl { get; set; }
        public string? PartnerCode { get; set; }
        public string? PartnerName { get; set; }
        public string? IpnUrl { get; set; }
        public string? RedirectUrl { get; set; }
        public string? AccessKey { get; set; }
        public string? SecretKey { get; set; }
    }
}
