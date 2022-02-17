using CommandLine;

namespace GapFinder;

[Verb("run", HelpText = "Runs the gap-finder application.")]
public class RunOptions
{
    [Option('i', "input", Required = true, HelpText = "Path to the input file.")]
    public string InputFile { get; set; } = string.Empty;
}

[Verb("generate", HelpText = "Generates an input file for the gap-finder application.")]
public class GenerateOptions
{
    [Option('o', "output", Required = true, HelpText = "Path to the output file.")]
    public string OutputFile { get; set; } = string.Empty;

    [Option('r', "randomise", HelpText = "Randomises the sequence of the output file.")]
    public bool Randomise { get; set; } = false;

    [Option('c', "count", Default = 100, HelpText = "Specifies the number of items in the sequence to be included in the output file.")]
    public int Count { get; set; } = 100;
}