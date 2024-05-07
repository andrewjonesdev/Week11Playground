using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class WeaponService : IWeaponService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<Weapon> _weapons;
        public WeaponService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _weapons = unitOfWork.Weapons;
        }
        public void AddWeapon(Weapon weapon)
        {
            _weapons.Add(weapon);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}