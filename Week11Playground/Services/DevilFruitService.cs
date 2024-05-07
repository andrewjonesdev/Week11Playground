using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class DevilFruitService : IDevilFruitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<DevilFruit> _devilFruits;
        public DevilFruitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _devilFruits = unitOfWork.DevilFruits;
        }
        public void AddDevilFruit(DevilFruit devilFruit)
        {
            _devilFruits.Add(devilFruit);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}