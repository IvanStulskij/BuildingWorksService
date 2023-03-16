using BuildingWorks.Databasable;
using BuildingWorksService.Extensions;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("ApiCors", policy =>
    {
        policy.WithOrigins("https://localhost:5257")
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
    });
});

builder.Services.AddDbContext<BuildingWorksDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.Parse("6.14"));
    options.EnableSensitiveDataLogging();
});

builder.Services.AddScoped<IDbContext>(provider => provider.GetService<BuildingWorksDbContext>());
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.ConfigureExceptionHandler();


app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseCors("ApiCors");

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
