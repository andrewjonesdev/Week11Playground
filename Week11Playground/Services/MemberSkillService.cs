using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class MemberSkillService : IMemberSkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<MemberSkill> _memberSkills;
        public MemberSkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _memberSkills = unitOfWork.MemberSkills;
        }
        public void AddMemberSkill(MemberSkill memberSkill)
        {
            _memberSkills.Add(memberSkill);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
