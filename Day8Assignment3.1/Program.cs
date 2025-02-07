var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    //
    app.UseHsts();
}

//for security
app.UseHttpsRedirection();

//midlleware to serve static files
app.UseStaticFiles();

//middleware for loging.....
app.UseRequestLogging();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
