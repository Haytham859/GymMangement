using GymMangement_BLL.Services.Interfaces;
using GymMangement_DAL.Dtos;
using GymMangement_DAL.Interfaces;
using GymMangement_DAL.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GymMangement_BLL.Services.Classes
{
    public class MemberService : IMemberService
    {


        private readonly IGenaricRepo<Member> _repo;

        public MemberService(IGenaricRepo<Member> repo)
        {

            _repo = repo;
        }

        public async Task<bool> CreateMemberAsync(CreateMemberDto model, CancellationToken cancellationToken = default)
        {
            //Check Email 

            var emailExist = await _repo.AnyAsync(a => a.Email == model.Email,cancellationToken);

            //Chech Phone

            var phoneExist = await _repo.AnyAsync(a => a.Phone == model.Phone, cancellationToken);

            if (emailExist || phoneExist)
                return false;


            var member = new Member
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                DateOfBirth=model.BirthDate,
                Gender= model.Gender,
                
                Address=new Address
                {
                    BuildingNumber=model.BuildingNumber,
                    City=model.City,
                    Street=model.Street,
                },
                HealthRecord =new HealthRecord
                {
                    BloodType=model.HealthRecordDto.BloodType,
                    Weight=model.HealthRecordDto.Weight,
                    Height=model.HealthRecordDto.Height,
                    Note=model.HealthRecordDto.Note
                }
                
            };

            var result = await _repo.AddAsync(member);

            return result > 0;

        }

        public async Task<IEnumerable<MemberDetailsDto>> GetAllMembersAsync(CancellationToken cancellationToken = default)
        {

            var members = await _repo.GetAllAsync(cancellationToken: cancellationToken);

            if (!members.Any())
                return [];


            //foreach (var m in members)
            //{
            //    var memberDtos = new MemberDetailsDto()
            //    {
            //        Name = m.Name,
            //        Id = m.Id,
            //        Email = m.Email,
            //        phone = m.Phone,
            //        Gender = m.Gender.Value,

            //    };

            //}


            var result = members.Select(a => new MemberDetailsDto {

                Name = a.Name,
                Id = a.Id,
                Email = a.Email,
                phone = a.Phone,
                Gender = a.Gender.Value,
            });

            return result;
        }
    }
}
