using G_NET97_EFC_Assignment_2.Configuration;
using G_NET97_EFC_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace G_NET97_EFC_Assignment_2.Contaxt
{
    public class AppDbContaxt : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProFile> OrganizerProFiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=.;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region OrganizerProFile (Fluent Apis)
            modelBuilder.Entity<OrganizerProFile>(E =>
                    {
                        E.HasKey(P => P.OrganizerProFileId);
                        E.Property(P => P.Bio).HasMaxLength(1000);
                        E.Property(P => P.WebSite).HasMaxLength(300);
                        E.Property(P => P.Logo).HasMaxLength(500);
                        E.HasOne(P => P.Organizer)
                        .WithOne(O => O.OrganizerProFile)
                        .HasForeignKey<OrganizerProFile>(P => P.OrganizerId)
                        .OnDelete(DeleteBehavior.Cascade);
                    }
            );
            #endregion

            #region Event & Badge (Fluent Apis)
            modelBuilder.ApplyConfiguration(new EvenConfiguration());
            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
            #endregion

        }

    }
}
