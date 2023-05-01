using AyzMuhasebeServer.Presentation;
using AyzMuhasebeServer.WebApi.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;

namespace AyzMuhasebeServer.WebApi.Configurations
{
    public class PresentationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ExceptionMiddleware>();
            services.AddControllers().AddApplicationPart(typeof(AssemblyReference).Assembly);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(setup =>
            {
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    BearerFormat = "JWT",
                    Name = "JWT Authentication",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

                setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {jwtSecurityScheme, Array.Empty<string>() }
                });
            });
            services.AddSwaggerGen(c =>
            {
                c.ResolveConflictingActions(apiDescriptions =>
                {
                    var descriptions = apiDescriptions as ApiDescription[] ?? apiDescriptions.ToArray();
                    var first = descriptions.First(); // build relative to the 1st method
                    var parameters = descriptions.SelectMany(d => d.ParameterDescriptions).ToList();

                    first.ParameterDescriptions.Clear();
                    // add parameters and make them optional
                    foreach (var parameter in parameters)
                        if (first.ParameterDescriptions.All(x => x.Name != parameter.Name))
                        {
                            first.ParameterDescriptions.Add(new ApiParameterDescription
                            {
                                ModelMetadata = parameter.ModelMetadata,
                                Name = parameter.Name,
                                ParameterDescriptor = parameter.ParameterDescriptor,
                                Source = parameter.Source,
                                IsRequired = false,
                                DefaultValue = null
                            });
                        }
                    return first;
                });
            });
        }
    }
}
