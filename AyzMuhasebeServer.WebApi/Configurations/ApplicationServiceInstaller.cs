using AyzMuhasebeServer.Application;
using AyzMuhasebeServer.Application.Behavior;
using FluentValidation;
using MediatR;

namespace AyzMuhasebeServer.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(AssemblyReference).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), (typeof(ValidationBehavior<,>)));
            services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
        }
    }
}
