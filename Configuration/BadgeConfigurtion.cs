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
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(B => B.BadgeId);
            builder.Property(B => B.BadgeNUmber)
                .IsRequired();
            builder.HasIndex(B => B.BadgeNUmber)
                .IsUnique();
            builder.Property(B => B.IssuedDate)
                .IsRequired();
            builder.Property(B => B.Tier)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(20);
            builder.HasOne(B => B.Attendee)
                .WithOne(A => A.Badge)
                .HasForeignKey<Badge>(B => B.AttendeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
