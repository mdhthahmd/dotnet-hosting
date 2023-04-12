using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if(!app.Environment.IsDevelopment())
{   
    app.UseHsts();
    app.UseHttpsRedirection();
    
    DefaultFilesOptions options = new DefaultFilesOptions();
        options.DefaultFileNames.Clear();
        options.DefaultFileNames.Add("index.html");
        options.RedirectToAppendTrailingSlash = false;
        options.RequestPath = "/dotnet-hosting";


    app.UseDefaultFiles(options);

    app.UseStaticFiles(new StaticFileOptions{
        FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "wwwroot")),
            RequestPath = "/dotnet-hosting",
            RedirectToAppendTrailingSlash = false
    });

    app.UsePathBase("/dotnet-hosting");

}

app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
    endpoints.MapFallbackToFile("index.html");
});

app.Run();

// https://github.com/vitejs/vite/discussions/7104
// https://learn.microsoft.com/en-us/aspnet/core/client-side/spa/intro?view=aspnetcore-7.0
