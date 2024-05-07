using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IWeaponService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddWeapon(Weapon weapon);
    }
}