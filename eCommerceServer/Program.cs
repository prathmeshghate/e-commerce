using BAL.homepage;
using DAL.homepage;
using Interface.homepage;
using Platform.DbConnection;
using Interface.CreateUpdate;
using BAL.CreateUpdate;
using Interface.CreateUpdateRepo;
using DAL.CreateUpdate;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {
//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateLifetime = true,
//             ValidateIssuerSigningKey = true,
//             ValidIssuer = builder.Configuration["Jwt:Issuer"],
//             ValidAudience = builder.Configuration["Jwt:Audience"],
//             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
//         };
//     });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ApplicationDbContext>();
builder.Services.AddAutoMapper(typeof(Program));
//MySql Connection 
string connString = builder.Configuration.GetConnectionString("DefaultConnectionMySQL");
builder.Services.AddDbContext<ApplicationDbContext>(Option => Option.UseMySQL(connString));

#region DependencyInjection

builder.Services.AddTransient<IHomepageProductRepositary, HomepageProductRepositary>();
builder.Services.AddTransient<IHomePageLogic, HomePageLogic>();
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

#region DependencyInjection

#endregion

#region DependencyInjection

#endregion
