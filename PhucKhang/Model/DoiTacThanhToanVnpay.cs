using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DoiTacThanhToanVnpay
    {
        public int Id { get; set; }
        public string MaDoiTac { get; set; } = null!;
        public string? TenDoiTac { get; set; }
        public string? VnpayUrl { get; set; }
        public string? Version { get; set; }
        public string? TmnCode { get; set; }
        public string? ReturnUrl { get; set; }
        public string? HashSecret { get; set; }
    }
}
