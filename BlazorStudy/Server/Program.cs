
using BlazorStudy.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string ConnectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(Db => Db.UseSqlServer(ConnectionString)
                                                            .EnableDetailedErrors()
                                                            .EnableSensitiveDataLogging()
                                                            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();

}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
