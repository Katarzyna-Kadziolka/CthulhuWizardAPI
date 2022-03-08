namespace CthulhuWizard.API.Options; 

public class RavenDbOptions {
    public const string Database = nameof(Database);
    public string DatabaseName { get; set; } = string.Empty;
    public string[] Urls { get; set; } = Array.Empty<string>();
}