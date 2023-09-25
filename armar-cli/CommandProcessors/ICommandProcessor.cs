using System;
using System.CommandLine;

namespace Armar.CLI.CommandProcessors
{
    public interface ICommandProcessor
    {
        Command CommandConfiguration { get; }
    }
}

