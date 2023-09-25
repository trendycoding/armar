using System.CommandLine;
using System.Text.Json;
using Armar.Core;

namespace Armar.CLI.CommandProcessors
{
    public class GenerateCommand : FileCommand
    {
        protected Option<string> _versionOption = new("--version", "Output folder for generated code") { IsRequired = false };
        protected Option<string> _folderOption = new("--folder", "Output folder for generated code") { IsRequired = false };
        protected Option<string> _languageOption = new("--lang", "Output folder for generated code") { IsRequired = false };

        public GenerateCommand(string name, string description) : base(name, description)
        {
            this._versionOption.FromAmong("v3", "v4").SetDefaultValue("v3");
            this._folderOption.SetDefaultValue(Directory.GetCurrentDirectory());
            this._languageOption.FromAmong("C#", "JavaScript", "TypeScript").SetDefaultValue("TypeScript");
        }

        protected override Command BuildCommand(string name, string description)
        {
            var command = base.BuildCommand(name, description);


            command.AddOption(this._folderOption);
            command.AddOption(this._versionOption);

            this.SetHandlingFunction(command);

            return command;
        }

        protected virtual void SetHandlingFunction(Command command)
        {
            command.SetHandler((file, folder, version, lang) =>
            {
                try
                {
                    var configContent = File.ReadAllText(file);
                    JsonSerializer.Deserialize<CodeGenerationConfig>(configContent);
                }
                catch (System.IO.FileNotFoundException fileNotFoundError)
                {
                    Console.WriteLine($"Unable to file the file {fileNotFoundError.FileName}");
                }
            }, this._fileOption, this._folderOption, this._versionOption, this._languageOption);

        }
    }
}