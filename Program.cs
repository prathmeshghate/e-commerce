using BAL.homepage;
using DAL.homepage;
using Interface.homepage;
using Microsoft.EntityFrameworkCore;
using Platform.DbConnection;
using AutoMapper;
using System.Globalization;
using mapper;
using Interface.CreateUpdate;
using BAL.CreateUpdate;
using Interface.CreateUpdateRepo;
using DAL.CreateUpdate;

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
        builder.Services.AddAutoMapper(typeof(Program));
        //MySql Connection 
        string connString = builder.Configuration.GetConnectionString("DefaultConnectionMySQL");
        builder.Services.AddDbContext<ApplicationDbContext>(Option => Option.UseMySql(connString, ServerVersion.AutoDetect(connString)));


        //DependencyInjection
        #region DependencyInjection

        builder.Services.AddTransient<IHomepageProductRepositary, HomepageProductRepositary>();
        builder.Services.AddTransient<IProductLogic, ProductLogic>();
        builder.Services.AddTransient<ICreateUpdateDbLogic, CreateUpdateDbLogic>();
        builder.Services.AddTransient<ICreateUpdateDbRepositary, CreateUpdateDbRepositary>();
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