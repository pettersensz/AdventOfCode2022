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


    internal int GetElfWithMostCaloriesResult()
    {
      Elf elfWithMostCalories = GetElfWithMostCalories();
      var calories = elfWithMostCalories.GetTotalCalories();
      return calories;
    }

    private Elf GetElfWithMostCalories()
    {
      var mostCaloriesElf = Elves.First();
      var calories = mostCaloriesElf.GetTotalCalories();
      foreach (var elf in Elves)
      {
        if(elf.GetTotalCalories() > calories)
        {
          mostCaloriesElf = elf;
          calories = elf.GetTotalCalories();
        }
      }
      return mostCaloriesElf;
    }

    internal int GetTopThreeElvesResult()
    {
      var topThreeElves = Elves.OrderByDescending(elf => elf.GetTotalCalories()).Take(3);
      var calories = 0;
      foreach(var elf in topThreeElves)
      {
        calories += elf.GetTotalCalories();
      }
      return calories;
    }

    internal class Food
    {
      public int Calories { get; set; }
    }

    internal class Elf
    {
      public List<Food> Foods { get; set; } = new List<Food>();

      internal int GetTotalCalories()
      {
        var calories = 0;
        foreach(var food in Foods)
        {
          calories += food.Calories;
        }
        return calories;
      }
    }

  }
}
