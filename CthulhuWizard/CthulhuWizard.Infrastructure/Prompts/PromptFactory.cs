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
        _prompt.Append($", {GetGender(_investigator.Gender)}");
        _prompt.Append($", {GetAge(_investigator.Age)}");
        _prompt.Append($", {GetOccupation(_investigator.Occupation!.Name!)}");
        _prompt.Append($", {GetBodyType(_investigator.Characteristic!.Strength, _investigator.Characteristic.Size)}");
        _prompt.Append($", {GetAppearance(_investigator.Characteristic.Appearance)}");

        return _prompt.ToString();
    }

    private static string GetGender(Gender gender) {
        if (gender is Gender.Female or Gender.Male) {
            return $"{gender.ToString()}";
        }

        return string.Empty;
    }

    private static string GetAge(int age) {
        return $"{age} years old";
    } 
    private static string GetOccupation(string occupation) {
        return $"{occupation}";
    }

    private static string GetBodyType(int strength, int size) {
        if (strength < 15) {
            return "";
        }
        if (size < 40) {
            return "";
        }
        if (strength < 41 && size < 57) {
            return "skinny";
        }

        if (strength < 41 && size < 74) {
            return "chubby";
        }

        if (strength < 41 && size < 90) {
            return "obese";
        }
        //
        if (strength < 66) {
            //enum size smallSize = 57 
            //mapper wartości gracza na moje enumy mały size, średni sie itd, i wtedy moge oprzeć się o sumy -> wtedy stringi tez mogą być enumami np. slim = 133
            if (size < 57) {
                return "slim";
            }
            if (size < 74) {
                return "average body type";
            }

            if (size < 90) {
                return "mighty";
            }
        }
        //

        if (strength < 90 && size < 57) {
            return "athletic";
        }

        if (strength < 90 && size < 74) {
            return "muscular";
        }

        if (strength < 90 && size < 90) {
            return "very muscular";
        }

        return string.Empty;
        // TODO Jakiś refactor?
    }

    private static string GetAppearance(int appearance) {
        if (appearance < 15) {
            return "disgusting";
        }
        if (appearance < 40) {
            return "ugly";
        }

        if (appearance < 66) {
            return "average appearance";
        }

        if (appearance < 90) {
            return "attractive";
        }

        return "captivating appearance";
    }

    // private static string GetCreditRating(int creditRating) {
    //     
    // }
}
