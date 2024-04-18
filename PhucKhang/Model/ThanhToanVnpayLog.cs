using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class ThanhToanVnpayLog
    {
        public int Id { get; set; }
        public decimal? VnpAmount { get; set; }
        public string? VnpBankCode { get; set; }
        public string? VnpBankTranNo { get; set; }
        public string? VnpCardType { get; set; }
        public string? VnpOrderInfo { get; set; }
        public DateTime? VnpPayDate { get; set; }
        public string? VnpResponseCode { get; set; }
        public string? VnpSecureHash { get; set; }
        public string? VnpTmnCode { get; set; }
        public string? VnpTransactionNo { get; set; }
        public string? VnpTransactionStatus { get; set; }
        public string? VnpTxnRef { get; set; }
        public string? Note { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? IpAddress { get; set; }
    }
}
