using System;
using System.Collections.Generic;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class Roles
    {
        public Roles()
        {
            Registration = new HashSet<Registration>();
        }

        public int RoleId { get; set; }
        public string Rolename { get; set; }

        public ICollection<Registration> Registration { get; set; }
    }
}
