/// <summary>
/// Configuration class to describe the project's folder structure
/// </summary>
public class ProjectStructureConfig
{
    /// <summary>
    /// The path to the project/repo folder
    /// </summary>
    public required string MainFolderPath { get; set; }
    /// <summary>
    /// The name of the folder where model classes will be stored
    /// </summary>
    public required string ModelsFolderName { get; set; };
    /// <summary>
    /// The name of the folder where business logic implementation code will be stored
    /// </summary>
    public required string ImplementationsFolderName { get; set; };
    /// <summary>
    /// </summary>
    /// The name of the folder where endpoints will be stored, empty by default
    public string EndPointsFolderName { get; set; } = "";
}