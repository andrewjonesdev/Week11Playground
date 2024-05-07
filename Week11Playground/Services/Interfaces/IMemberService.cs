using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IMemberService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddMember(Member member);
    }
}
