using AutoMapper;
using AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AyzMuhasebeServer.Application.Service.CompanyServices;
using AyzMuhasebeServer.Domain;
using AyzMuhasebeServer.Domain.CompanyEntities;
using AyzMuhasebeServer.Domain.Repositories.UCAFRepositories;
using AyzMuhasebeServer.Persistance.Context;

namespace AyzMuhasebeServer.Persistance.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IUCAFQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper, IUCAFQueryRepository queryRepository)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _queryRepository = queryRepository;
        }

        public async Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CretaeDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);

            uniformChartOfAccount.Id = Guid.NewGuid().ToString();

            await _commandRepository.AddAsync(uniformChartOfAccount, cancellationToken);

            await _unitOfWork.SaveChangeAsync(cancellationToken);
        }

        public async Task<UniformChartOfAccount> GetByCode(string code)
        {
            return await _queryRepository.GetFirstByExpression(p => p.Code == code);
        }
    }
}
