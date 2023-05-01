using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQuery() : IQuery<GetAllCompanyQueryResponse>;
