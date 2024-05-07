using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<Organization> _organizations;
        public OrganizationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _organizations = unitOfWork.Organizations;
        }
        public void AddOrganization(Organization organization)
        {
            _organizations.Add(organization);
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}