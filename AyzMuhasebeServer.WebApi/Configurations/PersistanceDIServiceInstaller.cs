using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Application.Service.CompanyServices;
using AyzMuhasebeServer.Domain;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using AyzMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using AyzMuhasebeServer.Domain.UnitOfWorks;
using AyzMuhasebeServer.Persistance;
using AyzMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories;
using AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;
using AyzMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using AyzMuhasebeServer.Persistance.Services.AppServices;
using AyzMuhasebeServer.Persistance.Services.CompanyServices;
using AyzMuhasebeServer.Persistance.UnitOfWorks;

namespace AyzMuhasebeServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitofWork
            services.AddScoped<ICompanyDbUnitOfWork, CompanyUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<ICompanyDbUnitOfWork, CompanyUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services

            #region CompanyDbContext
            services.AddScoped<IUCAFService, UCAFService>();
            #endregion

            #region AppDbContext
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMainRoleService, MainRoleService>();
            #endregion

            #endregion

            #region Repositories

            #region CompanyDbContext
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            #endregion

            #region AppDbContext
            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
            services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
            #endregion

            #endregion

        }
    }
}
