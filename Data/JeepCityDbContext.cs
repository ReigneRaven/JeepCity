using JeepCity.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JeepCity.Data
{
    public class JeepCityDbContext : DbContext
    {
        public JeepCityDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
