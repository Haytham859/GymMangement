using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Configurations
{
    public class MemberConfig:GymUserConfig<Member>,IEntityTypeConfiguration<Member>
    {

        public new void  Configure(EntityTypeBuilder<Member> builder)
        {


            builder.Property(a => a.CreatedAt)
                .HasColumnName("JoinDate")
                .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
