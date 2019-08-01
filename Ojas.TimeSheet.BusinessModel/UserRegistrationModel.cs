using System;
using System.Collections.Generic;
using System.Text;

namespace Ojas.TimeSheet.BusinessModel
{
    public class UserRegistrationModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassoword { get; set; }

        //public int RoleId { get; set; }
    }
}
