using HydraAPI.Services;
using HydraBusiness.Interfaces;
using HydraBusiness.Repositories;

namespace HydraAPI.Configurations;

public static class ConfigureBusinessService
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services){
        //Interfaces and Repositories
        services.AddScoped<ICandidateRepository, CandidateRepository>();

        //Services
        services.AddScoped<CandidateService>();
        return services;
    }
}
