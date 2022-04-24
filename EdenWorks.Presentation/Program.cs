using Autofac;
using Autofac.Extensions.DependencyInjection;
using EdenWorks.Domain.Entites;
using EdenWorks.Infrastructure;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using EdenWorks.Application.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers().AddFluentValidation(fv =>
{
    fv.DisableDataAnnotationsValidation=false;
    fv.RegisterValidatorsFromAssemblyContaining<Program>();
});


builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//AddDefaultIdentity comes with Microsoft.AspNetCore.Identity.UI,
//Required to change default identity value type (from guid to int)
builder.Services.AddDefaultIdentity<AppUser>(options => 
{
    options.Password.RequiredLength = 6;
    options.SignIn.RequireConfirmedAccount = true;
    
}).AddEntityFrameworkStores<AppDbContext>();

//Autofac IoC
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new DependencyResolver());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
