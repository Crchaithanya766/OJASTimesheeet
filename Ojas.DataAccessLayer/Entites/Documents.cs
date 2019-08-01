using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class Documents
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentBytes { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int ExpenseId { get; set; }
        public string DocumentType { get; set; }

        public Expense Expense { get; set; }
        public Registration User { get; set; }
    }
}
