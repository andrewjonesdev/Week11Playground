using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class MemberDevilFruitService : IMemberDevilFruitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<MemberDevilFruit> _memberDevilFruits;
        public MemberDevilFruitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _memberDevilFruits = unitOfWork.MemberDevilFruits;
        }
        public void AddMemberDevilFruit(MemberDevilFruit memberDevilFruit)
        {
            _memberDevilFruits.Add(memberDevilFruit);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
