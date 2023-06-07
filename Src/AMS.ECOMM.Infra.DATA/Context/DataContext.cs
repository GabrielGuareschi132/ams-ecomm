using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AMS.ECOMM.Infra.DATA.Context
{
  public class DataContext : DbContext
    {
  
  public DataContext(DbContextOpitions<DataContext>opitions):base(opitions){}

    
        DbSet<Product> product {get;set;}
        DbSet<Color> Color {get;set;}
        DbSet<Category> Category {get;set;}

    }
}