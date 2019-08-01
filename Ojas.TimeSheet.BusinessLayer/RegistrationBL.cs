using System;
using System.Collections.Generic;
using System.Text;
using Ojas.DataAccessLayer.Entites;
//Ojas.DataAccessLayer.Interfaces;
using Ojas.DataAccessLayer.Interfaces;
using Ojas.TimeSheet.BusinessModel;

namespace Ojas.TimeSheet.BusinessLayer
{
    public class RegistrationBL : IRegistrationBL
    {
        private IDataRepository<Registration> _dataRepository;
        public RegistrationBL(IDataRepository<Registration> _registration)
        {
            _dataRepository = _registration;
        }

        public bool RegisterUser(UserRegistrationModel model)
        {
            var CModel = Mapper.UserRegistrationMapper.ConvertToEntites(model);
            _dataRepository.Add(CModel);
            return true;
        }
    }
}
