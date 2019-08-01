using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class TimeSheetDetails
    {
        public int TimeSheetId { get; set; }
        public string DaysofWeek { get; set; }
        public int? Hours { get; set; }
        public DateTime? Period { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int TimeSheetMasterId { get; set; }
        public int? TotalHours { get; set; }

        public ProjectMaster Project { get; set; }
        public TimeSheetMaster TimeSheetMaster { get; set; }
        public Registration User { get; set; }
    }
}
