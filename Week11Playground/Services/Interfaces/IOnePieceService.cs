using Week11Playground.Models;

namespace Week11Playground.Services.Interfaces
{
    public interface IOnePieceService
    {
        public Task AddMember(MemberRequest member);
    }
}
