using AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AyzMuhasebeServer.Application.Service.CompanyServices;
using AyzMuhasebeServer.Domain.CompanyEntities;
using Moq;
using Shouldly;

namespace AyzMuhasebeServer.UnitTest.Features.CompanyFeatures.Commands;

public sealed class CreateUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _uCAFServiceMock;

    public CreateUCAFCommandUnitTest()
    {
        _uCAFServiceMock = new();
    }
    [Fact]
    public async Task UCAFShouldBeNull()
    {
        UniformChartOfAccount ucaf = await _uCAFServiceMock.Object.GetByCode("100.01.001",default);
        ucaf.ShouldBeNull();
    }

    [Fact]
    public async Task CreateUCAFCommandResponseShouldNotBeNull()
    {
        var command = new CreateUCAFCommand(
            Code: "100.01.001",
            Name: "TL Kasa",
            Type: 'M',
            CompanyId: "9846782b-ecff-4c09-b493-609a8712be71");

        var handler = new CreateUCAFCommandHandler(_uCAFServiceMock.Object);

        CreateUCAFCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
