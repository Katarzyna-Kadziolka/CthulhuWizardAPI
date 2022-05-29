using CthulhuWizard.Persistence.Models;
using CthulhuWizard.Persistence.Models.Investigators;
using MediatR.AspNet;

namespace CthulhuWizard.Application.Requests.Investigators.Commands.CreateInvestigator;

public class CreateInvestigatorCommand : ICommand<InvestigatorDto> {
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public Gender Gender{ get; set; }
    public string? BirthPlace { get; set; }
    public string? Residence { get; set; }
    public OccupationEntity? OccupationEntity { get; set; }
    public CharacteristicEntity? CharacteristicEntity { get; set; }
    public List<SkillEntity>? Skills { get; set; }
    public List<WeaponEntity>? Weapons { get; set; }
    public List<EquipmentEntity>? Equipments { get; set; }
    public AssetEntity? AssetEntity { get; set; }
    public BackstoryEntity? BackstoryEntity { get; set; }
}