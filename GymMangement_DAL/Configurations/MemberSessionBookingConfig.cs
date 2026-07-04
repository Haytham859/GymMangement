using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class MemberSessionBookingConfig : IEntityTypeConfiguration<MemberSessionBooking>
    {
        public void Configure(EntityTypeBuilder<MemberSessionBooking> builder)
        {

            builder.Ignore(a => a.Id);

            builder.Property(a => a.CreatedAt)
                .HasColumnName("BookingDate")
                .HasDefaultValueSql("GETDATE()");


            builder.HasKey(a => new { a.SessionId, a.MemberId });





        }
    }
}
