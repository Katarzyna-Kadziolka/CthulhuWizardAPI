using CthulhuWizard.API.Options;
using CthulhuWizard.Persistence.Contexts;
using CthulhuWizard.Persistence.Extensions;
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
        services.AddControllers();
        services.AddApiVersioning(
            config => {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
            });
        services.AddSwaggerGen(
            c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "CthulhuWizard", Version = "v1" }); });
        services.AddRavenDbContext();
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