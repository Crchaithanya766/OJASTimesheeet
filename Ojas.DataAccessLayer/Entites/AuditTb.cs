using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class AuditTb
    {
        public int AuditId { get; set; }
        public int UserId { get; set; }
        public string SessionId { get; set; }
        public string Ipaddress { get; set; }
        public string PageAccessed { get; set; }
        public DateTime? LoggedInAt { get; set; }
        public DateTime? LoggedOutAt { get; set; }
        public string LoginStatus { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string UrlReferrer { get; set; }

        public Registration User { get; set; }
    }
}
