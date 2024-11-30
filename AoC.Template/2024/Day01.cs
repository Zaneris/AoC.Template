using AdventOfCodeSupport;

namespace AoC.Template._2024;

public class Day01 : AdventBase
{
    protected override void InternalOnLoad()
    {
        // Optional override, runs before Part1/2.
        // Benchmarked separately.
    }

    protected override object InternalPart1()
    {
        // Part 1 solution here.
        Console.WriteLine($"Characters: {Input.Text.Length}");
        Console.WriteLine($"Lines: {Input.Lines.Length}");
        Console.WriteLine($"Blocks: {Input.Blocks.Length}");
        var bytes = Input.Bytes;
        var span = Input.Span;
        var span2d = Input.Span2D;
        var partOneAnswer = 42;
        return partOneAnswer;
    }

    protected override object InternalPart2()
    {
        // Part 2 solution here.
        Bag["Foo"] = "Bar"; // Pass information to unit tests.
        var partTwoAnswer = "ArDKz";
        return partTwoAnswer;
    }
}
