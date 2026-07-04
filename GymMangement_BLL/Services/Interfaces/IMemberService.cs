using GymMangement_DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement_BLL.Services.Interfaces
{
    public interface IMemberService
    {
        Task<IEnumerable<MemberDetailsDto>> GetAllMembersAsync(CancellationToken cancellationToken = default);

        Task<bool> CreateMemberAsync(CreateMemberDto model, CancellationToken cancellationToken = default);
        Task<MemberDetailsDto?> GetMemberByIdAsync(int id, CancellationToken cancellationToken = default);

    }
}
