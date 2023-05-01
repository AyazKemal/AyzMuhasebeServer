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
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using AyzMuhasebeServer.Application.Services.AppServices;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using AyzMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
//UsingSpot
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
            //CompanyServiceDISpot
            #endregion

            #region AppDbContext
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMainRoleService, MainRoleService>();
                services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
                services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
                services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
            //AppServiceDISpot
            #endregion

            #endregion

            #region Repositories

            #region CompanyDbContext
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            //CompanyRepositoryDISpot
            #endregion

            #region AppDbContext
            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
            services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
                services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
                services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
                services.AddScoped<IMainRoleAndRoleRelationshipCommandRepository, MainRoleAndRoleRelationshipCommandRepository>();
                services.AddScoped<IMainRoleAndRoleRelationshipQueryRepository, MainRoleAndRoleRelationshipQueryRepository>();
                services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
                services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();
            //AppRepositoryDISpot
            #endregion

            #endregion

        }
    }
}
