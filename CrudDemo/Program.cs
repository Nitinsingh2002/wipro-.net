using CrudDemo.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ProductDbContext>(opt => opt.UseSqlServer("data source=DESKTOP-FSGNJQG;initial catalog=CRUDRazor;trusted_connection=true;trustservercertificate=true;"));
var logger = builder.Services.BuildServiceProvider().GetRequiredService<ILogger<Program>>();


var app = builder.Build();

app.Use(async (context, next) =>
{
    // Log the incoming request method and path
    logger.LogInformation("Incoming Request: {Method} {Path}", context.Request.Method, context.Request.Path);

    // Proceed with the request pipeline
    await next.Invoke();

    // Log the response status code after the request is handled
    logger.LogInformation("Response Status Code: {StatusCode}", context.Response.StatusCode);
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
