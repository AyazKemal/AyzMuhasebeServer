using AyzMuhasebeServer.Domain.AppEntities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace AyzMuhasebeServer.Domain.AppEntities;

public sealed class MainRole : Entity
{
    public string Title { get; set; }
    public bool IsRoleCreatedByAdmin { get; set; }

    [ForeignKey("Company")]
    public string CompanyId { get; set; }
    public Company? Company { get; set; }
}
