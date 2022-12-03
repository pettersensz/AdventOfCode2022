using AdventOfCode2022.Shared;
using AdventOfCode2022.Week01;

namespace AdventOfCode2022
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var day1TestInput = ReadFile.ReadLinesInTextFile("Day01_example.txt");
      var day1Test = new Day01(day1TestInput);
      var day1TestResult = day1Test.GetElfWithMostCaloriesResult();
      Console.WriteLine("Day 01 Test 1: " + day1TestResult);
      var day1Part1Input = ReadFile.ReadLinesInTextFile("Day01_part1.txt");
      var day1Part1 = new Day01(day1Part1Input);
      var day1Part1Result = day1Part1.GetElfWithMostCaloriesResult();
      Console.WriteLine("Day 01 Part 1: " + day1Part1Result);
      var day1TestResult2 = day1Test.GetTopThreeElvesResult();
      Console.WriteLine("Day 01 Test 2: " + day1TestResult2);
      var day1Part2Result = day1Part1.GetTopThreeElvesResult();
      Console.WriteLine("Day 01 Part 1: " + day1Part2Result);
      Console.WriteLine("---- ---- ---- ---- ---- ---- ---- ----");

      var day2TestInput = ReadFile.ReadLinesInTextFile("Day02_example.txt");
      var day2Test = new Day02(day2TestInput);
      var day2TestPart1 = day2Test.GetTotalScore();
      Console.WriteLine("Day 02 Test 1: " + day2TestPart1);
      var day2Input = ReadFile.ReadLinesInTextFile("Day02_large.txt");
      var day2 = new Day02(day2Input);
      var day2Part1 = day2.GetTotalScore();
      Console.WriteLine("Day 02 Part 1: " + day2Part1);
      var day2TestPart2 = day2Test.GetTotalScoreWithDesiredOutcome();
      Console.WriteLine("Day 02 Test 2: " + day2TestPart2);
      var day2Part2 = day2.GetTotalScoreWithDesiredOutcome();
      Console.WriteLine("Day 02 Part 2: " + day2Part2);
    }
  }
}