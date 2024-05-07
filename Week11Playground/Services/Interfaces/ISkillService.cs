using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface ISkillService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddSkill(Skill skill);
    }
}
