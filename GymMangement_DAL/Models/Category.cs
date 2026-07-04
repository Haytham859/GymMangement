using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Models
{
    public class Category:BaseEntity
    {

        public string CategoryName {  get; set; }


        public ICollection<Session> Sessions {  get; set; }



    }
}
