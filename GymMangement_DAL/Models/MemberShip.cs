using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public class MemberShip
    {

        public int Id { get; set; }
        public Member Member { get; set; }
        public int MemberId {  get; set; }

        public Plan Plan { get; set; }
        public int PlanId {  get; set; }


        public DateTime StartsDate {  get; set; }
        public DateTime EndDate {  get; set; }

    }
}
