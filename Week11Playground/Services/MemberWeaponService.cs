using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class MemberWeaponService : IMemberWeaponService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<MemberWeapon> _memberWeapons;
        public MemberWeaponService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _memberWeapons = unitOfWork.MemberWeapons;
        }
        public void AddMemberWeapon(MemberWeapon memberWeapon)
        {
            _memberWeapons.Add(memberWeapon);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
