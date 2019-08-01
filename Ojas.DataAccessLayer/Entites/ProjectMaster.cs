using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class ProjectMaster
    {
        public ProjectMaster()
        {
            DescriptionTb = new HashSet<DescriptionTb>();
            Expense = new HashSet<Expense>();
            TimeSheetDetails = new HashSet<TimeSheetDetails>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string NatureofIndustry { get; set; }
        public string ProjectCode { get; set; }

        public ICollection<DescriptionTb> DescriptionTb { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<TimeSheetDetails> TimeSheetDetails { get; set; }
    }
}
