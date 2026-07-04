using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public class Plan:BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationDay {  get; set; }
        public decimal Price {  get; set; }
        public bool IsActive { get; set; }


        public ICollection<MemberShip> PlanMembers { get; set; }

    }
}
