using BuildingWorks.Databasable;
using BuildingWorksService.ActionFilters;
using BuildingWorksService.Extensions;
using Microsoft.EntityFrameworkCore;
using Models.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BuildingWorksDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.Parse("6.14"));
    options.EnableSensitiveDataLogging();
});

builder.Services.AddScoped<IDbContext>(provider => provider.GetService<BuildingWorksDbContext>());
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddControllersWithViews(config =>
{
    config.Filters.Add(new ValidationFilterAttribute());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper();
builder.Services.AddAttributes();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.ConfigureExceptionHandler();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.Run();
