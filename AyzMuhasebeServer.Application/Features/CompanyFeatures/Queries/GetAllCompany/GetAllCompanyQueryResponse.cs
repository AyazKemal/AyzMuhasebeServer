using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQueryResponse(IList<Company> Companies);
