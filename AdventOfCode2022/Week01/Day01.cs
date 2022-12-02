using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Week01
{
  internal class Day01
  {
    public List<Elf> Elves { get; set; } = new List<Elf>();

    public Day01(string[] inputData)
    {
      var elf = new Elf();
      foreach (var line in inputData)
      {
        if(line.Length > 0)
        {
          elf.Foods.Add(new Food() { Calories = int.Parse(line) });
        }
        else
        {
          Elves.Add(elf);
          elf = new Elf();
        }
      }
      Elves.Add(elf);
    }

    internal class Food
    {
      public int Calories { get; set; }
    }

    internal class Elf
    {
      public List<Food> Foods { get; set; } = new List<Food>();
    }
  }
}
