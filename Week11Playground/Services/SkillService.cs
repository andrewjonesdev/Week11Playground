using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<Skill> _skills;
        public SkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _skills = unitOfWork.Skills;
        }
        public void AddSkill(Skill skill)
        {
            _skills.Add(skill);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}