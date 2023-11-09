using AutoMapper;
using CthulhuWizard.Application.Requests.Investigators.Mappings;

namespace CthulhuWizard.Tests.Shared; 

public class TestMapper {
    private static readonly Lazy<IMapper> Lazy =
        new(() => {
            var mappingConfig = new MapperConfiguration(mc
                => {
                mc.AddMaps(typeof(InvestigatorMappingProfile).Assembly);
            });
            return mappingConfig.CreateMapper();
        });
 
    public static IMapper Instance => Lazy.Value;

    private TestMapper() { }
}
