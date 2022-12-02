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
    }
  }
}