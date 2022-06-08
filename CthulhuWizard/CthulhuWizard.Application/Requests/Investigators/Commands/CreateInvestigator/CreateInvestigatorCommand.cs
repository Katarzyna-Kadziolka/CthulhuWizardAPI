using CthulhuWizard.Application.Requests.Occupations;
using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;

public class CreateInvestigatorCommand : ICommand<InvestigatorDetailsDto> {
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public Gender Gender{ get; set; }
    public string? BirthPlace { get; set; }
    public string? Residence { get; set; }
    public OccupationDetailsDto? Occupation { get; set; }
    public CharacteristicDto? Characteristic { get; set; }
    public List<SkillEntity>? Skills { get; set; }
    public List<WeaponEntity>? Weapons { get; set; }
    public List<EquipmentEntity>? Equipments { get; set; }
    public AssetDto? Asset { get; set; }
    public BackstoryDto? Backstory { get; set; }
    public string? ImageUrl { get; set; }
}