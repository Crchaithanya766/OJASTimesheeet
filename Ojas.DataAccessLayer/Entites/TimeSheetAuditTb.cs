using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class TimeSheetAuditTb
    {
        public int ApprovalTimeSheetLogId { get; set; }
        public int? ApprovalUser { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Comment { get; set; }
        public int? Status { get; set; }
        public int TimeSheetId { get; set; }
        public int UserId { get; set; }

        public Registration User { get; set; }
    }
}
