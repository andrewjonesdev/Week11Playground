using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IMemberDevilFruitService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddMemberDevilFruit(MemberDevilFruit memberDevilFruit);
    }
}
