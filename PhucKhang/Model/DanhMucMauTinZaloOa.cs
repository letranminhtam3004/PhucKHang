using System;
using System.Collections.Generic;

namespace PhucKhang.Model
{
    public partial class DanhMucMauTinZaloOa
    {
        public string? Id { get; set; }
        public string? TemplateId { get; set; }
        public string? TemplateName { get; set; }
        public string? Type { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
