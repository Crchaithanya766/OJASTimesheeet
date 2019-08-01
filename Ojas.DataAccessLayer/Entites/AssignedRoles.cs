using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class AssignedRoles
    {
        public int AssignedRolesId { get; set; }
        public int? AssignToAdmin { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int RegistrationId { get; set; }

        public Registration Registration { get; set; }
    }
}
