using App.Core;
using App.Infra.EFCore;
using App.Services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Services
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var siteSettings = configuration.GetSection("SiteSettings").Get<SiteSettings>();
builder.Services.AddSingleton<SiteSettings>();

builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=UserManagementDB ; Integrated Security=True; TrustServerCertificate=True;"));

builder.Services.AddInfraEfCore(builder.Configuration);
builder.Services.AddAppServiceRegistration();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseStatusCodePagesWithRedirects("/Home/PageNotFound");

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
