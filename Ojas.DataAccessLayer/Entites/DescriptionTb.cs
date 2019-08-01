using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class DescriptionTb
    {
        public int DescriptionId { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int? TimeSheetMasterId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int UserId { get; set; }

        public DescriptionTb DescriptionNavigation { get; set; }
        public ProjectMaster Project { get; set; }
        public Registration User { get; set; }
        public DescriptionTb InverseDescriptionNavigation { get; set; }
    }
}
