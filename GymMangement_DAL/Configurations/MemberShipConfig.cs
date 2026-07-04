using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class MemberShipConfig : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(a => a.Id);


            builder.Property(a => a.StartsDate)
                .HasDefaultValueSql("GETDATE()");
 

        }
    }
}
