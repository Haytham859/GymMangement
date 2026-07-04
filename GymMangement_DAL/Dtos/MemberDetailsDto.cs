using GymMangement_DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_DAL.Dtos
{
    public class MemberDetailsDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email {  get; set; }

        public Gender Gender { get; set; }

        public string Phone { get; set; }

        public string Photo {  get; set; }



        ///////////////////
        ///
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }

        public string? PlanName { get; set; }

        public string? MemberShipStartDate {  get; set; }
        public string? MemberShipEndDate {  get; set; }



    }
}
