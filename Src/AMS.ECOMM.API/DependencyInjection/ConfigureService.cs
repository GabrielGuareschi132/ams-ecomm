using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace AMS.ECOMM.API.DependencyInjection
{
    public class ConfigureService
    {
       public static void ConfigurationDependenciesServices(IServicesCollections services, IConfiguration configuration)
       {
         services.AddScoped<IProduct, ProductRepository>();
         Services.AddEntityFrameworkSqlServer();
         AddDbContext<DataContext>(
            options.UseSqlLite(configuration.GetConnectionString("DataBase"))
         );
        
       }
    }
}