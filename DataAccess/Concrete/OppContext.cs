using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class OppContext : IdentityDbContext<AppUser,AppRole,string>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User Id=postgres;Password=123;Server=localhost;Port=5432;Database=OppProject;");      
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Psychologist> Psychologists { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<WorkingProgram> WorkingPrograms { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
