using AyzMuhasebeServer.Application.Messaging;
using AyzMuhasebeServer.Application.Service.CompanyServices;
using AyzMuhasebeServer.Domain.CompanyEntities;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFCommandHandler(IUCAFService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            UniformChartOfAccount ucaf = await _ucafService.GetByCode(request.Code, cancellationToken);

            if (ucaf != null) throw new Exception("Bu Hesap Planı Kodu Daha Önce Tanımlanmış");

            await _ucafService.CreateUcafAsync(request, cancellationToken);
            return new();
        }
    }
}
