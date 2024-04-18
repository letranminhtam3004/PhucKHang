using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class LogSendZaloOa
    {
        public int LogId { get; set; }
        public string? Loai { get; set; }
        public string? TemplateId { get; set; }
        public string? StatusCode { get; set; }
        public string? Phone { get; set; }
        public string? OrderCode { get; set; }
        public string? CreatorId { get; set; }
        public string? Response { get; set; }
        public DateTime? LogTime { get; set; }
    }
}
