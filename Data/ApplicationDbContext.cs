using HotelReservation.Models.DB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bed> Beds { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelComment> HotelComments { get; set; }
        public DbSet<HotelFacility> HotelFacilities { get; set; }
        public DbSet<HotelGallery> HotelGalleries { get; set; }
        public DbSet<HotelInfo> HotelInfoes { get; set; }
        public DbSet<HotelRate> HotelRates { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<PaymentGatway> PaymentGatways { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.; DataBase=HotelReservationDb; Trusted_connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HotelInfo>()
                .HasOne(h => h.Hotel)
                .WithMany(a => a.HotelInfos)
                .HasForeignKey(g => g.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelInfo>()
                .HasOne(h => h.Room)
                .WithMany(r => r.Rooms)
                .HasForeignKey(h => h.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelInfo>()
                .HasOne(h => h.Bed)
                .WithMany(b => b.Beds)
                .HasForeignKey(h => h.BedId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelInfo>()
                .HasOne(h => h.HotelRate)
                .WithMany(r => r.Rates)
                .HasForeignKey(h => h.RateId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelInfo>()
                .HasOne(h => h.Province)
                .WithMany(p => p.Provinces)
                .HasForeignKey(h => h.ProvinceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelGallery>()
                .HasOne(g => g.Hotel)
                .WithMany(h => h.HotelGalleries)
                .HasForeignKey(g => g.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelComment>()
                .HasOne(c => c.Hotel)
                .WithMany(h => h.HotelComments)
                .HasForeignKey(c => c.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelFacility>()
                .HasOne(f => f.Hotel)
                .WithMany(h => h.HotelFacilities)
                .HasForeignKey(f => f.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Reservations)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Hotel)
                .WithMany(h => h.Orders)
                .HasForeignKey(o => o.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Reservation)
                .WithOne(r => r.Order)
                .HasForeignKey<Order>(o => o.ResevationId)
                .OnDelete(DeleteBehavior.Restrict);

        }
            

    }

}
