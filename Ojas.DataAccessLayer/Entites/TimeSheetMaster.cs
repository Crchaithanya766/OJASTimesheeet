using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class TimeSheetMaster
    {
        public TimeSheetMaster()
        {
            TimeSheetDetails = new HashSet<TimeSheetDetails>();
        }

        public int TimeSheetMasterId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TotalHours { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Comment { get; set; }
        public int? TimeSheetStatus { get; set; }

        public Registration User { get; set; }
        public ICollection<TimeSheetDetails> TimeSheetDetails { get; set; }
    }
}
