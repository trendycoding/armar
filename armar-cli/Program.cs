// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.CommandLine.Parsing;
using Armar.CLI;
using Armar.CLI.CommandProcessors;

ICommandProcessor[] processors = {
    new GenerateCommand("generate", "Generates a C#,TS, or JS project that provides API endpoints"),
    new SampleCommand("sample", "Generates a sample JSON file to jumpstart the API configuration")
};

var rootCommand = CommandOptions.CommandConfiguration(processors);

return rootCommand.Invoke(args);
