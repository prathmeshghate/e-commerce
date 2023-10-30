// using application.DbContext;
using System.Security.Cryptography.X509Certificates;
using BAL.homepage;
using DAL.homepage;
// using Google.Protobuf.WellKnownTypes;
using Interface.homepage;
using Microsoft.EntityFrameworkCore;
using Platform.DbConnection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        IServiceCollection _services = new ServiceCollection();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddControllersWithViews();

        builder.Services.AddScoped<ApplicationDbContext>();
        //MySql Connection 
        string connString = builder.Configuration.GetConnectionString("DefaultConnectionMySQL");
        builder.Services.AddDbContext<ApplicationDbContext>(Option => Option.UseMySql(connString, ServerVersion.AutoDetect(connString)));


        //DependencyInjection
        #region DependencyInjection

        _services.AddTransient<IHomepageProductRepositary, HomepageProductRepositary>();
        _services.AddTransient<IProductLogic, ProductLogic>();

        #endregion


        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}