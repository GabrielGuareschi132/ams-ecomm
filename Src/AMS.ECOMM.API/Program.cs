using AMS.ECOMM.API;
using AMS.ECOMM.DOMAIN.Core.Interfaces.Repository;
using AMS.ECOMM.Infra.DATA.Context;
using AMS.ECOMM.Infra.DATA.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
// Add services to the container.




