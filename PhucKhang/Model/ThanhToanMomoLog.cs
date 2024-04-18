using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class ThanhToanMomoLog
    {
        public int Id { get; set; }
        public string? PartnerCode { get; set; }
        public string? OrderId { get; set; }
        public string? RequestId { get; set; }
        public decimal? Amount { get; set; }
        public string? OrderInfo { get; set; }
        public string? OrderType { get; set; }
        public string? TransId { get; set; }
        public string? ResultCode { get; set; }
        public string? Message { get; set; }
        public string? PayType { get; set; }
        public long? ResponseTime { get; set; }
        public string? ExtraData { get; set; }
        public string? Signature { get; set; }
    }
}
