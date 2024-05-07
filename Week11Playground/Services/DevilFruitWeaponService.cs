using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class DevilFruitWeaponService : IDevilFruitWeaponService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<DevilFruitWeapon> _devilFruitWeapons;
        public DevilFruitWeaponService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _devilFruitWeapons = unitOfWork.DevilFruitWeapons;
        }
        public void AddDevilFruitWeapon(DevilFruitWeapon devilFruitWeapon)
        {
            _devilFruitWeapons.Add(devilFruitWeapon);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
