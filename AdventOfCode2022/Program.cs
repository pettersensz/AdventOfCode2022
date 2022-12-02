﻿using AdventOfCode2022.Shared;
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
      Console.WriteLine("Day 01 Test  : " + day1TestResult);
      var day1Part1Input = ReadFile.ReadLinesInTextFile("Day01_part1.txt");
      var day1Part1 = new Day01(day1Part1Input);
      var day1Part1Result = day1Part1.GetElfWithMostCaloriesResult();
      Console.WriteLine("Day 01 Part 1: " + day1Part1Result);
    }
  }
}