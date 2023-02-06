var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();

// https://alexpotter.dev/net-6-with-vue-3/
// https://github.com/dotnet/aspnetcore/tree/main/src/Middleware/Spa/SpaServices.Extensions/src
// https://github.com/vitejs/vite/discussions/7104
// https://learn.microsoft.com/en-us/aspnet/core/client-side/spa/intro?view=aspnetcore-7.0
