using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class Expense
    {
        public Expense()
        {
            Documents = new HashSet<Documents>();
            ExpenseAuditTb = new HashSet<ExpenseAuditTb>();
        }

        public int ExpenseId { get; set; }
        public string PurposeorReason { get; set; }
        public int? ExpenseStatus { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string VoucherId { get; set; }
        public int? HotelBills { get; set; }
        public int? TravelBills { get; set; }
        public int? MealsBills { get; set; }
        public int? LandLineBills { get; set; }
        public int? TransportBills { get; set; }
        public int? MobileBills { get; set; }
        public int? Miscellaneous { get; set; }
        public int? TotalAmount { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Comment { get; set; }
        public int ProjectId { get; set; }

        public ProjectMaster Project { get; set; }
        public Registration User { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<ExpenseAuditTb> ExpenseAuditTb { get; set; }
    }
}
