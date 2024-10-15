using HotelProject.EntityLayers.Concrete;
using HotelProjectDataAccesLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the containe
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
//Register
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

//Add AutoMappe
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
