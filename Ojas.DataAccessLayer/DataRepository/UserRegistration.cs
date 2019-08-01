using Ojas.DataAccessLayer.Entites;
using Ojas.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ojas.DataAccessLayer.DataRepository
{
    public class UserRegistration : IDataRepository<Registration>
    {
        public bool Add(Registration model)
        {
            using (var dt = new OjasTimeSheetDBContext())
            {
                dt.Registration.Add(model);
                dt.SaveChanges();
            }
            return true;
        }
    }
}
