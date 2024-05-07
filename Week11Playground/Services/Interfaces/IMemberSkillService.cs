using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IMemberSkillService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddMemberSkill(MemberSkill memberSkill);
    }
}
