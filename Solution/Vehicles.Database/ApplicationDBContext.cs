using Microsoft.EntityFrameworkCore;
using Vehicles.Database.Entities;

namespace Vehicles.Database
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<VehicleEntity> Vehicles { get; set; }


        public ApplicationDBContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VehicleDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            /* UNIQUE constraint beallitas
             * builder.Entity<VehicleEntity>()
             *        .HasIndex(x => x.LicensePlate)
             *        .IsUnique();
             */
            modelBuilder.Entity<ColorEntity>().HasData(
                new ColorEntity
                {
                    Id = 1,
                    Name = "White",
                    Code = "ffffff"
                });
            modelBuilder.Entity<ColorEntity>().HasData(
                new ColorEntity
                {
                    Id = 2,
                    Name = "Black",
                    Code = "000000"
                });
        }
    }
}
