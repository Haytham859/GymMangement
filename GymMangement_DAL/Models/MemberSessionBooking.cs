using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public class MemberSessionBooking:BaseEntity
    {
        public Member Member { get; set; }

        public int MemberId {  get; set; }


        public Session Session { get; set; }
        public int SessionId { get; set; }

        //BookingDate=CreateAt of BaseEntity
        public bool IsAttend {  get; set; }



    }
}
