namespace AMS.ECOMM.API
{
    public class Startup
    {
     public  Iconfiguration Configuration{get;}

     public Startup (Iconfiguration configuration){
        Configuration = configuration; 
     }   
    }

    public void Configure(IApplicationBuilder app, IwebHostEnvironment env)
    {

        var application = app.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    application.UseHttpsRedirection();

    application.UseAuthorization();

    application.MapControllers();

    application.Run();
    
    
    
    
    
    app.UseSwagger();
    app.UseSwaggerUI();
}



    }

    public void ConfigureSrv(IServiceCollections services)
    {
        ConfigureService.ConfigurationDependenciesServices(services, Configuration);
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}