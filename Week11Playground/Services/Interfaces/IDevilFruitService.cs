using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IDevilFruitService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddDevilFruit(DevilFruit devilFruit);
    }
}