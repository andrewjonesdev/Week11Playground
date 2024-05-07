using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IDevilFruitWeaponService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddDevilFruitWeapon(DevilFruitWeapon devilFruitWeapon);
    }
}
