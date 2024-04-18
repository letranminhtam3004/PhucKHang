using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class WebhookGhtk
    {
        public int Id { get; set; }
        public string LabelId { get; set; } = null!;
        public string PartnerId { get; set; } = null!;
        public DateTime ActionTime { get; set; }
        public int StatusId { get; set; }
        public string? ReasonCode { get; set; }
        public string? Reason { get; set; }
        public double? Weight { get; set; }
        public double? Fee { get; set; }
        public int? ReturnPartPackage { get; set; }
        public DateTime NgayHeThong { get; set; }
    }
}
