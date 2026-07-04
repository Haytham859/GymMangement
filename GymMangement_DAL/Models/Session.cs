using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public class Session:BaseEntity
    {


        public string Description { get; set; } = default!;
        public int Capacity {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }


        public Trainer Trainer { get; set; }

        public int TrainerId {  get; set; }


        public Category Category { get; set; }
        public int CaTegoryId {  get; set; }

        public ICollection<MemberSessionBooking> MemberSessionBookings { get; set; }




    }
}
