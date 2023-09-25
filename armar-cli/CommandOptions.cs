using System;
using System.CommandLine;
using Armar.CLI.CommandProcessors;

namespace Armar.CLI
{
	public static class CommandOptions
	{
		public static RootCommand CommandConfiguration(ICommandProcessor[] processors)
		{
			var rootCommand = new RootCommand("CLI tool for generating Azure Function REST APIs");
            foreach (var processor in processors)
			{
                rootCommand.AddCommand(processor.CommandConfiguration);
			}

            return rootCommand;
		}        
    }
}

