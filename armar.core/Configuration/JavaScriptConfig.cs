using System.Runtime.InteropServices.JavaScript;

namespace Armar.Core
{
    /// <summary>
    /// Class describing the configuration needed for a JavaScript API
    /// </summary>
    public class JavaScriptConfig
    {
        /// <summary>
        /// Package configuration, maps to the package.json file
        /// </summary>
        public JSPackage Package { get; set; } = new();
        /// <summary>
        /// Hosting configuration, maps to the host.json
        /// </summary>
        public JSHostSection HostSection { get; set; } = new();
        /// <summary>
        /// Local setting for the project, maps to local.settings.json
        /// </summary>
        public JSLocalSettings LocalSettings { get; set; } = new();

    }

    /// <summary>
    /// Class describing a package configuration, maps to the package.json file
    /// </summary>
    public class JSPackage
    {
        /// <summary>
        /// Name of the package/ptoject
        /// </summary>
        public string Name { get; set; } = "boilerplate-api";
        /// <summary>
        /// Version of the project
        /// </summary>
        public string Version { get; set; } = "1.0.0";
        /// <summary>
        /// Decription of the project
        /// </summary>
        public string Description { get; set; } = "Boiler plate json to kick start Armar configurations";
        /// <summary>
        /// Scripts to manage npm executions
        /// </summary>
        public Dictionary<string, string> Scripts { get; set; } = new()
        {
            {"build", "tsc"},
            {"watch", "tsc -w"},
            {"prestart", "npm run build"},
            {"start", "func start"},
            {"test", "echo 'No tests yet...'"}
        };
        /// <summary>
        /// Dependencies to include in the project matches the dependencies section of the package.json
        /// </summary>
        public Dictionary<string, string> Dependencies { get; set; } = new() { };
        /// <summary>
        /// Development dependencies matches the devDependencies section of the package.json
        /// </summary>
        public Dictionary<string, string> DevDependencies { get; set; } = new(){
            {"@azure/functions", "^2.0.0"},
            {"@types/node", "14.x"},
            {"typescript", "~4.7.4"}
        };
    }

    /// <summary>
    /// Hosting configuration matching the host.json
    /// </summary>
    public class JSHostSection
    {
        /// <summary>
        /// LocalHttpPort section
        /// </summary>
        public int LocalHttpPort = 7072;
        /// <summary>
        /// CORS setting for the local project
        /// </summary>
        public string CORS = "*";
        /// <summary>
        /// CORS Credential requirements setting for the local hosting
        /// </summary>
        public bool CORSCredentials = false;
    }

    /// <summary>
    /// Class describing local settings section of the JS projects
    /// </summary>
    public class JSLocalSettings
    {
        /// <summary>
        /// Encryption flag for the local settings
        /// </summary>
        public bool IsEncrypted = false;
        /// <summary>
        /// Key/Value structure containing the local settings
        /// </summary>
        public Dictionary<string, string>? Values;
    }
}