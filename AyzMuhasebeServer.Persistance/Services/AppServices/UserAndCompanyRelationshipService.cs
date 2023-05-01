using AyzMuhasebeServer.Application.Services.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using AyzMuhasebeServer.Domain.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace AyzMuhasebeServer.Persistance.Services.AppServices;

public class UserAndCompanyRelationshipService : IUserAndCompanyRelationshipService
{
    private readonly IUserAndCompanyRelationshipCommandRepository _commandRepository;
    private readonly IUserAndCompanyRelationshipQueryRepository _queryRepository;
    private readonly IAppUnitOfWork _unitOfWork;

    public UserAndCompanyRelationshipService(IAppUnitOfWork unitOfWork, IUserAndCompanyRelationshipQueryRepository queryRepository, IUserAndCompanyRelationshipCommandRepository commandRepository)
    {
        _unitOfWork = unitOfWork;
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship, CancellationToken cancellationToken)
    {
       await _commandRepository.AddAsync(userAndCompanyRelationship, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship)
    {
        throw new NotImplementedException();
    }

    public async Task<UserAndCompanyRelationship> GetByIdAsync(string id)
    {
        return await _queryRepository.GetById(id);
    }

    public async Task<UserAndCompanyRelationship> GetByUserIdAndCompanyId(string userId, string companyId, CancellationToken cancellationToken)
    {
        return await _queryRepository.GetFirstByExpression(p => p.AppUserId == userId && p.CompanyId == companyId, cancellationToken);
    }

    public async Task<IList<UserAndCompanyRelationship>> GetListByUserId(string userId)
    {
        return await _queryRepository.GetWhere(p => p.AppUserId == userId).Include("Company").ToListAsync();
    }

    public async Task RemoveByIdAsync(string id)
    {
        await _commandRepository.RemoveById(id);
        await _unitOfWork.SaveChangesAsync();
    }
}
