using DeerCoffeeShop.API.Services;
using DeerCoffeeShop.Application.Common.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace DeerCoffeeShop.API.Configuration
{
    public static class ApplicationSecurityConfiguration
    {
        public static IServiceCollection ConfigureApplicationSecurity(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<JwtService>();
            JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
            services.AddHttpContextAccessor();

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)

            //    .AddJwtBearer(
            //        JwtBearerDefaults.AuthenticationScheme,
            //        options =>
            //        {
            //            options.Authority = "https://deercoffeesystem.azurewebsites.net/";
            //            options.Audience = "api";
            //            options.TokenValidationParameters.RoleClaimType = "role";
            //            options.SaveToken = true;
            //        });
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidateIssuerSigningKey = true,
                        ValidateLifetime = true,
                        ValidIssuer = "https://deercoffeesystem.azurewebsites.net/",
                        ValidAudience = "api",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Deer Coffee Shop @PI 123abc456 anh iu em")),
                    };
                });

            services.AddAuthorization(ConfigureAuthorization);

            return services;
        }


        private static void ConfigureAuthorization(AuthorizationOptions options)
        {

        }
    }
}
