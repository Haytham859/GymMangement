using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {



            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("CheckCapacity", "Capacity Between 1 and 25");
                tb.HasCheckConstraint("CheckEndData", "EndDate > StartDate");


            });
        }
    }
}
