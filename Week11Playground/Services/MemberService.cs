using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class MemberService : IMemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<Member> _members;
        public MemberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _members = unitOfWork.Members;
        }
        public void AddMember(Member member)
        {
            _members.Add(member);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
