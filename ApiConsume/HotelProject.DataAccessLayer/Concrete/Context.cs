using HotelProject.EntityLayers.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using System.Configuration; // ConfigurationManager için gerekli

namespace HotelProjectDataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected readonly IConfiguration Configuration;

        public Context(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Bağlantı dizesini burada ayarlayın
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonias { get; set; }
    }
}