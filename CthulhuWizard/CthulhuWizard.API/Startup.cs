using CthulhuWizard.Application;
using CthulhuWizard.Application.Extensions;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Persistence.Extensions;
using CthulhuWizard.Persistence.Options;
using FluentValidation.AspNetCore;
using MediatR.AspNet;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;

namespace CthulhuWizard.API;

public class Startup {
    public Startup(IConfiguration configuration, IHostEnvironment environment) {
        Configuration = configuration;
        Environment = environment;
    }

    public IConfiguration Configuration { get; }
    public IHostEnvironment Environment { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services) {
        services.AddOptions<RavenDbOptions>().Bind(Configuration.GetSection(RavenDbOptions.Database));
        services.AddRavenDbContext();
        services.AddIdentityDbContext(Configuration, Environment);
        services.AddApplication();
        services.AddCors();
        services
            .AddControllers(o => o.Filters.AddMediatrExceptions())
            .AddNewtonsoftJson(o => o.SerializerSettings.Converters.Add(new StringEnumConverter()));
        services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateInvestigatorCommandValidator>());
        services.AddApiVersioning(
            config => {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        services.AddSwaggerGen(
            c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "CthulhuWizard", Version = "v1" }); });
        services.AddSwaggerGenNewtonsoftSupport();

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if (env.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();
        
        app.UseCors(builder =>
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}
