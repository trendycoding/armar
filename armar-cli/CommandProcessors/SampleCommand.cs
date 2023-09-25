using Armar.Core;
using Armar.CLI.CommandProcessors;
using System.Text.Json;
using System.CommandLine;

public class SampleCommand : GenerateCommand
{
    protected Option<bool> _replaceOption = new("--replace", "Output folder for generated code") { IsRequired = false };
    public SampleCommand(string name, string description) : base(name, description)
    {
        this._replaceOption.SetDefaultValue(false);
    }

    protected override Command BuildCommand(string name, string description)
    {
        var command = base.BuildCommand(name, description);

        command.AddOption(this._replaceOption);

        return command;
    }

    protected override void SetHandlingFunction(Command command)
    {
        command.SetHandler((file, folder, version, lang, withForceReplace) =>
        {
            if (File.Exists(file) && !withForceReplace)
            {
                Console.WriteLine($"A file with name {file} already exists, manually delete the file if you want to overwrinte it.");
                return;
            }

            CodeGenerationConfig codeGenCfg = new CodeGenerationConfig()
            {
                TypeScript = new TypeScriptConfig()
                {
                    Package = new JSPackage(),
                    HostSection = new JSHostSection(),
                    LocalSettings = new JSLocalSettings(),
                    TypeScriptSettings = new TSConfigSettings()
                    {
                        CompilerOptions = new TSCompilerOptions()
                    }
                },
                JavaScript = new JavaScriptConfig()
                {
                    Package = new JSPackage(),
                    HostSection = new JSHostSection(),
                    LocalSettings = new JSLocalSettings()
                },
                CSharp = new CSharpConfig()
                {
                    NameSpace = "SampleCompany.ApplicationName.API",
                    ModelsNameSpace = "SampleCompany.ApplicationName.API.Models",
                    BusinessLogicNameSpace = "SampleCompany.ApplicationName.API.BusinessLogic",
                    ValidationNameSpace = "SampleCompany.ApplicationName.API.Validation"
                }
            };

            string json = JsonSerializer.Serialize(codeGenCfg, new JsonSerializerOptions() { WriteIndented = true });

            File.WriteAllText(file, json);
        }, this._fileOption, this._folderOption, this._versionOption, this._languageOption, this._replaceOption);
    }
}