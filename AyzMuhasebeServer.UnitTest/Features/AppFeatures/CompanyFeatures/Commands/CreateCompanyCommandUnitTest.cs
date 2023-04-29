using AyzMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.AppFeatures.CompanyFeatures.Commands;

public sealed class CreateCompanyCommandUnitTest
{
    private readonly Mock<ICompanyService> _companyService;

    public CreateCompanyCommandUnitTest()
    {
        _companyService = new();
    }

    [Fact]
    public async Task CompanyShouldBeNull()
    {
        Company company = (await _companyService.Object.GetCompanyByName("Ayaz Ltd Şti"))!;
        company.ShouldBeNull();
    }

    [Fact]
    public async Task CreateCompanyCommandResponseShouldBeNull()
    {
        var command = new CreateCompanyCommand(
            Name: "Ayaz Ltd Şti",
            ServerName: "localhost",
            DatabaseName: "AyazMuhasebeDb",
            UserId: "",
            Password: "");
        var handler = new CreateCompanyCommandHandler(_companyService.Object);
        CreateCompanyCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}


