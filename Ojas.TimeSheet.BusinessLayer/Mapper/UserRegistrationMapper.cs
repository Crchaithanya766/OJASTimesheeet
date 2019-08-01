using Ojas.DataAccessLayer.Entites;
using Ojas.TimeSheet.BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ojas.TimeSheet.BusinessLayer.Mapper
{
    public class UserRegistrationMapper
    {
        public static Registration ConvertToEntites(UserRegistrationModel model)
        {
            return new Registration()
            {
                Name = model.Name,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassoword,
                CreatedOn = DateTime.Now,
                Username = model.UserName,
                EmailId = model.Email,
                Mobileno = model.MobileNumber
            };
        }
    }
}
