using System;
using System.CommandLine;
using System.Windows.Input;

namespace Armar.CLI.CommandProcessors
{
	public abstract class AbstractCommandProcessor : ICommandProcessor
	{
        protected readonly Command _commandConfig;        

        public AbstractCommandProcessor(string name, string description)
		{
            this._commandConfig = this.BuildCommand(name, description);
        }

        protected virtual Command BuildCommand(string name, string description)
        {
            return new Command(name, description);
        }

        public Command CommandConfiguration => this._commandConfig;
    }
}

