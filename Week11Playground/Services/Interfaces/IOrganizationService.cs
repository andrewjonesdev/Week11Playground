using Week11Playground.Models.Entities;

namespace Week11Playground.Services.Interfaces
{
    public interface IOrganizationService
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void AddOrganization(Organization organization);
    }
}