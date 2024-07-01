var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Account",
    pattern: "{area:exists}/{controller=Logon}/{action=Login}/{id?}",
    defaults: new { area = "Account" });

app.MapControllerRoute(
    name: "Home",
    pattern: "{area:exists}/{controller=Home}/{action=Dashboard}/{id?}",
    defaults: new { area = "Home" });

app.MapAreaControllerRoute(
    name: "Home",
    areaName: "Home",
    pattern: "{area:exists}/{controller=Home}/{action=Dashboard}/{id?}");

app.Run();

         