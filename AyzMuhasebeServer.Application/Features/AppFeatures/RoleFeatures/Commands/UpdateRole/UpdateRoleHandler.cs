using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);

            if (role == null) throw new Exception("Role Bulunamadı");

            if (role.Code != request.Code)
            {
                AppRole checkCode = await _roleService.GetByCode(request.Code);
                if (checkCode != null) throw new Exception("Bu Kod daka Önce Kaydedilmiş");
            }

            role.Code = request.Code;
            role.Name = request.Name;
            await _roleService.UpdateAsync(role);
            return new();
        }
    }
}
