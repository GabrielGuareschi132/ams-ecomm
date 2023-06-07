using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.ECOMM.DOMAIN.Core.Entities;
using AMS.ECOMM.DOMAIN.Core.Interfaces.Repository;
using AMS.ECOMM.DOMAIN.Core.Interfaces.Services;

namespace AMS.ECOMM.SERVICES.Service
{
    public class ProductService : IBaseService<Product>
    {
        
     public readonly Irepository<Product> _repository;
     
      public ProductService(IRepository<Product> repository)
      {
        _repository = repository;
      }

        public async Task Add(T entity)
        {
          await _repository.Add(entity);
         
        }

        public Task<IEnumerable<Product>> GetAll()
        {
           
        }

        public Task<Product> GetById(Guid id)
        {

        }
    }
}