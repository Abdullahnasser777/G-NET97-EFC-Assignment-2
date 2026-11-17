using G_NET97_EFC_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EFC_Assignment_2.Configuration
{
    public class EvenConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(E => E.EventId);
            builder.Property(E => E.Title)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(E => E.StarDate)
                .IsRequired();
            builder.Property(E => E.EndDate)
                .IsRequired(false);
            builder.Property(E => E.MaxAttendees)
                .IsRequired();
            builder.HasOne(E => E.Organizer)
                .WithMany(O=>O.Events)
                .HasForeignKey(E=>E.OrganizerId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
