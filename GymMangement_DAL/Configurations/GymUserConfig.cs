using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class GymUserConfig<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {

            builder.Property(a => a.Name)
                            .HasColumnType("VarChar")
                            .HasMaxLength(50);

            builder.Property(a => a.Email)
                .HasColumnType("VarChar")
                .HasMaxLength(100);

            builder.HasIndex(a => a.Email).IsUnique();

            builder.HasIndex(a => a.Phone).IsUnique();
            builder.Property(a => a.Gender).HasColumnType("varchar(6)");

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("EmailCheck", "Email Like '_%@_%._%'");

                tb.HasCheckConstraint("PhoneCheck", "Phone Like '011%' or  Phone Like '012%' or Phone Like '010%' or Phone Like '015%'");


                 


            });
            builder.OwnsOne(a => a.Address, address =>
            {

                address.Property(a => a.Street).HasColumnName("Street").HasColumnType("VarChar").HasMaxLength(30);

                address.Property(a => a.City).HasColumnName("City").HasColumnType("VarChar").HasMaxLength(30);

            });


        }
    }
}
