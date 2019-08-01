using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class Registration
    {
        public Registration()
        {
            AssignedRoles = new HashSet<AssignedRoles>();
            AuditTb = new HashSet<AuditTb>();
            DescriptionTb = new HashSet<DescriptionTb>();
            Documents = new HashSet<Documents>();
            Expense = new HashSet<Expense>();
            ExpenseAuditTb = new HashSet<ExpenseAuditTb>();
            TimeSheetAuditTb = new HashSet<TimeSheetAuditTb>();
            TimeSheetDetails = new HashSet<TimeSheetDetails>();
            TimeSheetMaster = new HashSet<TimeSheetMaster>();
        }

        public int RegistrationId { get; set; }
        public string Name { get; set; }
        public string Mobileno { get; set; }
        public string EmailId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public int RoleId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? DateofJoining { get; set; }
        public int? ForceChangePassword { get; set; }

        public Roles Role { get; set; }
        public ICollection<AssignedRoles> AssignedRoles { get; set; }
        public ICollection<AuditTb> AuditTb { get; set; }
        public ICollection<DescriptionTb> DescriptionTb { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<ExpenseAuditTb> ExpenseAuditTb { get; set; }
        public ICollection<TimeSheetAuditTb> TimeSheetAuditTb { get; set; }
        public ICollection<TimeSheetDetails> TimeSheetDetails { get; set; }
        public ICollection<TimeSheetMaster> TimeSheetMaster { get; set; }
    }
}
