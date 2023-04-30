using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQuery() : IQuery<GetAllCompanyQueryResponse>;
