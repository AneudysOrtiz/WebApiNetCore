using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Data
{
    public class MyApiContext : DbContext
    {
        public MyApiContext(DbContextOptions<MyApiContext> options) : base(options)
        {

        }

        public DbSet<Persona> personas { get; set; }
    }
}