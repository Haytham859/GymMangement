using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(a => a.CategoryName)
                            .HasColumnType("VarChar")
                            .HasMaxLength(20);


            builder.Property(a => a.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");


            builder.HasData(

                new Category { Id=1,CategoryName="Cardio"},
                new Category { Id = 2, CategoryName = "Strenght" },
                new Category { Id = 3, CategoryName = "Yoga" },
                new Category { Id = 4, CategoryName = "Boxing" },
                new Category { Id = 5, CategoryName = "CrossFit" }
                );
        }
    }
}
