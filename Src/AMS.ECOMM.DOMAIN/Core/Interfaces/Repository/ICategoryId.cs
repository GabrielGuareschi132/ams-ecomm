using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AMS.ECOMM.DOMAIN.Core.Interfaces.Repository
{
    public interface ICategoryId : IRepository<CategoryId>
    {
         Task Add();
     Task<IEnumerable<T>> GetAll();
     Task<T> GetbyId(Guid id);
       void Update(Guid id);  
       void Delete(Guid id); 
    }
}