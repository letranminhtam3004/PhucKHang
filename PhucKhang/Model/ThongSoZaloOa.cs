using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class ThongSoZaloOa
    {
        public string? AppId { get; set; }
        public string? SecretKey { get; set; }
        public string? RefreshToken { get; set; }
        public string? AccessToken { get; set; }
        public DateTime? ExpiresToken { get; set; }
    }
}
