using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQueryResponse(IList<Company> Companies);
