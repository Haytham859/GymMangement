using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public  class HealthRecord:BaseEntity
    {
        public decimal Height {  get; set; }
        public decimal Weight {  get; set; }

        public string? Note {  get; set; }

        public string BloodType {  get; set; }



        #region Member_HealthRecord_Relationship


        public Member Member { get; set; } = default!;

        public int MemberId { get; set; }



        #endregion

    }
}
