using AyzMuhasebeServer.Application.Abstractions;
using AyzMuhasebeServer.Infrasturcture.Authentication;

namespace AyzMuhasebeServer.WebApi.Configurations
{
    public class InfrustructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
