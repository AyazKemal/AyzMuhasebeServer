using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Application.Service.CompanyServices;
using AyzMuhasebeServer.Domain.Repositories.UCAFRepositories;
using AyzMuhasebeServer.Domain;
using AyzMuhasebeServer.Persistance.Repositories.UCAFRepositories;
using AyzMuhasebeServer.Persistance.Services.AppServices;
using AyzMuhasebeServer.Persistance.Services.CompanyServices;
using AyzMuhasebeServer.Persistance;

namespace AyzMuhasebeServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitofWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUCAFService, UCAFService>();
            services.AddScoped<IRoleService, RoleService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            #endregion

        }
    }
}
