using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProjectDataAccesLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Controller servislerini ekle
builder.Services.AddControllers();


// Eklemek istediðin servisler
builder.Services.AddDbContext<Context>(); // Veritabaný baðlantýsý

//CONTROLLER APÝLERÝ ÝÇÝN ÇALIÞTIRMA...
builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.AddScoped<IServicesDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();

builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscibeService, SubscribeManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts => {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
// Swagger/OpenAPI yapýlandýrmasý
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("OtelApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
