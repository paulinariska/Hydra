using System.Text;
using HydraAPI.Configurations;
using HydraDataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace HydraAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        var builder = WebApplication.CreateBuilder(args);
        IServiceCollection services = builder.Services;
        ConfigurationManager configuration = builder.Configuration;
        Dependencies.ConfigureService(configuration, services); // make class 'Dependencies' in DataAccess then make project reference to Business and Business to DataAccess;
        services.AddControllers();
        services.AddBusinessServices();
        services.AddSwaggerGen(options => {
            options.SwaggerDoc("v1", new OpenApiInfo(){Title ="MIdas API"});
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme{
                Description = "Enter the token with the `Bearer ` prefix, e.g. 'Bearer abcdefg1234'",
                In = ParameterLocation.Header,
                Name ="Authorization",
                Type = SecuritySchemeType.ApiKey,
            });
            options.OperationFilter<SecurityRequirementsOperationFilter>();
        });
        services.AddCors(options =>
        {
           options.AddPolicy(name: MyAllowSpecificOrigins,
                            policy => 
                            {
                                policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
                            }); 
        });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(option => {
                option.TokenValidationParameters = new TokenValidationParameters(){
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings: Token").Value??"")
                    ),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        services.AddAuthorization();

        var app = builder.Build();
        app.UseRouting();
        app.MapControllers();
        if(app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(MyAllowSpecificOrigins);
        app.UseAuthentication();
        app.UseAuthorization();

        app.Run();
    }
}
