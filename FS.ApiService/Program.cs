using FS.ServiceDefaults;
using FS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using FS.Data.Models.Users;
using FS.Data.Models.Roles;
using FS.Data.Repositories;
using FS.Data.UOWs;

using static Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
using var configuration = builder.Configuration;
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<FSDatabaseContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
builder.Services.AddScoped<IUnitofWork, UnitofWork>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = AuthenticationScheme;
        options.DefaultChallengeScheme = AuthenticationScheme;
        options.DefaultScheme = AuthenticationScheme;
    })

// Adding Jwt Bearer
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidAudience = configuration["JWT:ValidAudience"],
            ValidIssuer = configuration["JWT:ValidIssuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]!)),
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapDefaultEndpoints();

app.Run();