using GymMangement_DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public  class Member:GymUser
    {

        public string? Photo {  get; set; }


        #region Member_HealthRecord_Relationship
        public HealthRecord HealthRecord { get; set; } = default!;
        #endregion


        public ICollection<Session> Sessions {  get; set; }


        public ICollection<MemberShip>MemberShips { get; set; }

        public ICollection<MemberSessionBooking>Bookings { get; set; }
    }
}
