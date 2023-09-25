using System;
using System.CommandLine;

namespace Armar.CLI.CommandProcessors
{
    public class FileCommand : AbstractCommandProcessor
    {
        protected readonly Option<string> _fileOption = new("--input", "Input file (usually the configuration file with information about the action(s) to perform") { IsRequired = true };

        public FileCommand(string name, string description): base(name, description)
        {
        }

        protected override Command BuildCommand(string name, string description)
        {
            var commnad = base.BuildCommand(name, description);            
            commnad.AddOption(this._fileOption);

            return commnad;
        }

    }
}

