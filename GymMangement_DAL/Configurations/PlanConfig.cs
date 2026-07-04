using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {



            builder.Property(a => a.Name)
                .HasColumnType("VarChar")
                .HasMaxLength(50);

            builder.Property(a => a.Description)
                .HasColumnType("VarChar")
                .HasMaxLength(200);


            builder.Property(a => a.Price)
                .HasPrecision(10, 2);

            builder.Property(a => a.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("PlanDurationCheck", "DurationDay Between 1 and 365");

            });
        }
    }
}
