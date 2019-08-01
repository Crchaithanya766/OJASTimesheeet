using Ojas.TimeSheet.BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ojas.TimeSheet.BusinessLayer
{
    public interface IRegistrationBL
    {
        bool RegisterUser(UserRegistrationModel model);
    }
}
