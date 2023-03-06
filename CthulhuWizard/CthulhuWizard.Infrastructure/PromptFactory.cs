using System.Text;
using CthulhuWizard.Application.Requests.Investigators;
using CthulhuWizard.Persistence.Models.Investigators;

namespace CthulhuWizard.Infrastructure;

public class PromptFactory {
    private const string PromptStart = "Black and white portrait photograph, 1920s";
    private const string PromprEnd = "you can see whole head, high resolution";
    private readonly InvestigatorDetailsDto _investigator;
    private StringBuilder _prompt = new (PromptStart);
    public PromptFactory(InvestigatorDetailsDto investigator) {
        _investigator = investigator;
    }
    public string Create() {
        _prompt.Append(GetGender(_investigator.Gender));
        _prompt.Append(GetAge(_investigator.Age));
        _prompt.Append(GetOccupation(_investigator.Occupation!.Name!));

        return _prompt.ToString();
    }

    private static string GetGender(Gender gender) {
        if (gender is Gender.Female or Gender.Male) {
            return $", {gender.ToString()}";
        }

        return string.Empty;
    }

    private static string GetAge(int age) {
        return $", {age} years old";
    } 
    private static string GetOccupation(string occupation) {
        return $", {occupation}";
    }

    private static string GetBodyType(int strength, int size) {
        if (strength < 41 && size < 57) {
            
        }

    }

}
