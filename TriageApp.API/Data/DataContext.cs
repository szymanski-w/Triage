using Microsoft.EntityFrameworkCore;
using TriageApp.API.Models;

namespace TriageApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}