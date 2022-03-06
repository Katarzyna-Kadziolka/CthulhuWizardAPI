namespace CthulhuWizard.API.Options; 

public class RavenDbOptions {
    public const string Database = "Databse";
    public string DatabaseName { get; set; } = string.Empty;
    public string[] Urls { get; set; }
}