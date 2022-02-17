using GapFinder;
using CommandLine;

Parser.Default.ParseArguments<RunOptions, GenerateOptions>(args)
    .WithParsed<RunOptions>(HandleRun)
    .WithParsed<GenerateOptions>(HandleGenerate)
    .WithNotParsed(HandleParseError);

static void HandleParseError(IEnumerable<Error> errs)
{
    Console.WriteLine("Invalid arguments.");
}

static void HandleRun(RunOptions options)
{
    var content = File.ReadAllText(options.InputFile);
    var sequence = content?.Split(" ") ?? new string[0];
    var converted = sequence.Select(n => int.Parse(n)).ToArray();

    var missing = SequenceScanner.FindMissingNumber(converted, Incrementers.IncrementByOneButStartWithOne);
    Console.WriteLine($"Input: {options.InputFile}");
    Console.WriteLine($"Missing number in the sequence: {missing}");
}

static void HandleGenerate(GenerateOptions options)
{
    if (options.Count <= 0) { throw new ArgumentOutOfRangeException("Value must be greater than 0.", nameof(options.Count)); }

    var sequence = SequenceGenerator.Generate(options.Count, Incrementers.IncrementByOneButStartWithOne);
    var excludedIndex = new Random(Guid.NewGuid().GetHashCode()).Next(0, options.Count - 1);
    var excludedNumber = sequence[excludedIndex];

    var newSequence = sequence.Where((n, i) => i != excludedIndex).ToArray();
    var content = options.Randomise ? SequenceGenerator.Randomise(newSequence) : newSequence;

    File.WriteAllText(options.OutputFile, string.Join(" ", content));
    Console.WriteLine($"Generated output: {options.OutputFile}");
    Console.WriteLine($"Missing number in the sequence: {excludedNumber}");
}