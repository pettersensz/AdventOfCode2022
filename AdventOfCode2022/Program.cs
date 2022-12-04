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
      Console.WriteLine("---- ---- ---- ---- ---- ---- ---- ----");

      var day3TestInput = ReadFile.ReadLinesInTextFile("Day03_example.txt");
      var day3Test = new Day03(day3TestInput);
      var day3TestPart1 = day3Test.GetPriorities();
      Console.WriteLine("Day 03 Test 1: " + day3TestPart1);
      var day3Input = ReadFile.ReadLinesInTextFile("Day03_large.txt");
      var day3 = new Day03(day3Input);
      var day3Part1 = day3.GetPriorities();
      Console.WriteLine("Day 03 Part 1: " + day3Part1);
      var day3TestPart2 = day3Test.GetPrioritiesForGroup();
      Console.WriteLine("Day 03 Test 2: " + day3TestPart2);
      var day3Part2 = day3.GetPrioritiesForGroup();
      Console.WriteLine("Day 03 Part 2: " + day3Part2);
      Console.WriteLine("---- ---- ---- ---- ---- ---- ---- ----");

      var day4TestInput = ReadFile.ReadLinesInTextFile("Day04_example.txt");
      var day4Test = new Day04(day4TestInput);
      Console.WriteLine("Day 04 Test 1: " + day4Test.CommonAreasCounter);
      var day4Input = ReadFile.ReadLinesInTextFile("Day04_large.txt");
      var day4 = new Day04(day4Input);
      Console.WriteLine("Day 04 Part 1: " + day4.CommonAreasCounter);
      Console.WriteLine("Day 04 Test 2: " + day4Test.IntersectCounter);
      Console.WriteLine("Day 04 Part 2: " + day4.IntersectCounter);
    }
  }
}