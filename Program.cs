using AutoMapper;
using FitnessApp.Configuration;
using FitnessApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Fitness App API",
        Version = "v1",
        Description = "Fitness app API used in fitness tracking app",
    });
});

builder.Services.AddControllersWithViews();

builder.Services.AddCors(cors =>
{
    cors.AddPolicy("dev", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
});



var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperConfiguration());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var connectionString = builder.Configuration.GetConnectionString("TrustedConnection");
builder.Services.AddDbContext<FitnessAppDbContext>(x => x.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sporty Pal API V1");

    c.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
