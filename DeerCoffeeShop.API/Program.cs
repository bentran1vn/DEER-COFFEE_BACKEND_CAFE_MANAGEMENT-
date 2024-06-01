using DeerCoffeeShop.API.Configuration;
using DeerCoffeeShop.API.Filters;
using DeerCoffeeShop.Application;
using DeerCoffeeShop.Application.Common.Interfaces;
using DeerCoffeeShop.Infrastructure;
using Serilog;

// Create the builder
var builder = WebApplication.CreateBuilder(args);

// Configure logging (Serilog)
builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext()
    .WriteTo.File("Logs/logs.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.Console());

// Add services
builder.Services.AddControllers(opt =>
{
    opt.Filters.Add<ExceptionFilter>();
});
builder.Services.AddApplication(); // Note: 'Configuration' is available on the builder
builder.Services.ConfigureApplicationSecurity(builder.Configuration);
builder.Services.ConfigureProblemDetails();
builder.Services.ConfigureApiVersioning();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.ConfigureSwagger();
builder.Services.ConfigurationCors();
//allow all cors
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
               builder =>
               {
                   builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
               });
});
// Build the app
var app = builder.Build();

// Configure the middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSerilogRequestLogging();
app.UseExceptionHandler();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors("CorsPolicy");
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});



app.UseSwashbuckle(); // 'Configuration' is available on the app
// Start the application
await app.RunAsync();
