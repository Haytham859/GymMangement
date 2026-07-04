using GymMangement_BLL.Services.Interfaces;
using GymMangement_DAL.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata.Ecma335;

namespace GymMangement_PL.Controllers
{
    public class MemberController:Controller
    {
        // Get BaseUrl/Member/Index
        //Index   Show List All Members


        private readonly IMemberService _memberService;
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToken=default)
        {

            var members = await _memberService.GetAllMembersAsync(cancellationToken: cancellationToken);


            return View(members);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {


            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(CreateMemberDto model)
        {

            if (!ModelState.IsValid)
                return View(model);

            var result =await _memberService.CreateMemberAsync(model);


            if (result)
                TempData["SuccessMessage"] = "Member Created Successfully";
            else
                TempData["ErrorMessage"] = "Faild To Create Member";

            return RedirectToAction(nameof(Index));




            return View(model);
            

        }
        public async Task<IActionResult> MemberDetails(int id, CancellationToken cancellationToken = default)
        {

            var member = await _memberService.GetMemberByIdAsync(id, cancellationToken);

            if (member is null)
            {
                TempData["ErrorMessage"] = "Member Not Found";

                
                return RedirectToAction(nameof(Index));
         
       
       
            }

            return View(member);
        
        }



    }
}
