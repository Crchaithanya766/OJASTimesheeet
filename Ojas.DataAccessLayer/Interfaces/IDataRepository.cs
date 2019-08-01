using System;
using System.Collections.Generic;
using System.Text;

namespace Ojas.DataAccessLayer.Interfaces
{
    public interface IDataRepository<T>
    {
        bool Add(T model);
    }
}
