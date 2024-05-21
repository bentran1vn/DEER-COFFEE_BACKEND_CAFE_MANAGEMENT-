namespace DeerCoffeeShop.API.Configuration
{
    public static class CorsConfiguration
    {
        public static IServiceCollection ConfigurationCors(this IServiceCollection services)
        {
            services.AddCors(o =>
            {
                o.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });

            return services;
        }
    }
}
