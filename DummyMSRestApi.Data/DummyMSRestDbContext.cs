using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using DummyMSRestApi.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DummyMSRestApi.Data.Configurations;

namespace DummyMSRestApi.Data
{
    public class DummyMSRestDbContext : IdentityDbContext<UserType>
    {
        public DummyMSRestDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<LineData<TypeFields>> typeDatas { get; set; }
        public DbSet<LineData<TimeFields>> timeDatas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfigurations());
            modelBuilder.ApplyConfiguration(new LineDataTimeFieldsConfigurations());
            modelBuilder.ApplyConfiguration(new LineDataTypeFieldsConfigurations());
            
        }

        
    }
}
