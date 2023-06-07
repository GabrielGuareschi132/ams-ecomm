using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AMS.ECOMM.DOMAIN.Core.Interfaces.Services

{      public interface IBaseService<T> where T: class
    {
         Task Add(T entity);
         Task<IEnumerable<T>> GetAll();
         Task<T> GetbyId(Guid id);
        void Update(T entity);
     
    }
}