using LabaWebApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LabaWebApp.API.dbContext
{
    public class PatientsDbContext : DbContext
    {
        public PatientsDbContext(DbContextOptions<PatientsDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
