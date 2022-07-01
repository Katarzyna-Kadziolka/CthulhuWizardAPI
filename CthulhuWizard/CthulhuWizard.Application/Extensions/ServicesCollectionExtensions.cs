using CthulhuWizard.Application.Requests.Investigators.Queries.GetInvestigators;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CthulhuWizard.Application.Extensions; 

public static class ServicesCollectionExtensions {
	public static void AddApplication(this IServiceCollection services) {
		services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
		services.AddMediatR(typeof(GetInvestigatorsQuery));
	}
}