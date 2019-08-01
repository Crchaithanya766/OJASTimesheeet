using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class NotificationsTb
    {
        public int NotificationsId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
