using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IMemberWeaponService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddMemberWeapon(MemberWeapon memberWeapon);
    }
}
