﻿using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed record UpdateRoleCommand(
        string Id,
        string Code, 
        string Name) : ICommand<UpdateRoleCommandResponse>;
}
