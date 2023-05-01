using AutoMapper;
using AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using AyzMuhasebeServer.Application.Features.CompanyFeatures.Commands.CreateCompany;
using AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using AyzMuhasebeServer.Domain.CompanyEntities;

namespace AyzMuhasebeServer.Persistance.Migrations.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyCommand, Company>();
            CreateMap<CreateUCAFCommand, UniformChartOfAccount>();
            CreateMap<CreateRoleCommand, AppRole>();
        }
    }
}
