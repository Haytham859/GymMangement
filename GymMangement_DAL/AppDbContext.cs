using GymMangement_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL
{
    public class AppDbContext:DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public DbSet<HealthRecord> HealthRecords { get; set; }

        public DbSet<MemberSessionBooking> Bookings { get; set; }

        public DbSet<MemberShip> MemberShips { get; set; }






    }
}
