using CthulhuWizard.Application;
using CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;
using CthulhuWizard.Persistence.Extensions;
using CthulhuWizard.Persistence.Options;
using FluentValidation.AspNetCore;
using MediatR.AspNet;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace CthulhuWizard.API;

public class Startup {
    public Startup(IConfiguration configuration) {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services) {
        services.AddOptions<RavenDbOptions>().Bind(Configuration.GetSection(RavenDbOptions.Database));
        services.AddRavenDbContext();
        services.AddIdentityDbContext(Configuration.GetConnectionString("DefaultConnection"));
        services.AddApplication();
        services.AddControllers(o => o.Filters.AddMediatrExceptions());
        services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateInvestigatorCommandValidator>());
        services.AddApiVersioning(
            config => {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
            });
        services.AddSwaggerGen(
            c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "CthulhuWizard", Version = "v1" }); });

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

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}