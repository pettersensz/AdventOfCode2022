namespace AdventOfCode2022.Week01
{
 internal class Day03
 {
  public List<Rucksack> Rucksacks { get; set; } = new();
  public Day03(string[] input)
  {
   foreach (var line in input)
   {
    var rucksack = new Rucksack();
    //Console.Write(line.Length + "-");
    var part1 = line.Substring(0, line.Length / 2);
    rucksack.Compartment1 = part1.ToCharArray();
    //Console.Write(part1.Length + "-");
    var part2 = line.Substring(line.Length / 2);
    rucksack.Compartment2 = part2.ToCharArray();
    //Console.Write(part2.Length + "\n");
    Rucksacks.Add(rucksack);
   }
  }

  internal class Rucksack
  {
   public char[]? Compartment1 { get; set; }
   public char[]? Compartment2 { get; set; }
  }

  internal int GetPriorities()
  {
   var prioritiesSum = 0;
   foreach (var rucksack in Rucksacks)
   {
    char commonChar = FindCommonChar(rucksack);
    //Console.Write(commonChar + " - ");
    var priority = GetPriority(commonChar);
    prioritiesSum += priority;
   }
   return prioritiesSum;
  }

  internal int GetPrioritiesForGroup()
  {
   var priorities = 0;
   for (var i = 0; i < Rucksacks.Count; i = i + 3)
   {
    var commonChar = FindCommonCharInThree(i);
    var priority = GetPriority(commonChar);
    //Console.WriteLine(commonChar + " - " + priority);
    priorities += priority;
   }
   return priorities;
  }

  private int GetPriority(char character)
  {
   var priority = character % 32;
   if (Char.IsUpper(character)) priority += 26;
   //Console.Write(priority + "\n");
   return priority;
  }

  private char FindCommonChar(Rucksack rucksack)
  {
   if (rucksack.Compartment1 != null && rucksack.Compartment2 != null)
   {
    var commonChar = rucksack.Compartment1.Where(c => rucksack.Compartment2.Contains(c)).First();
    return commonChar;
   }
   throw (new InvalidOperationException("Complartments not initialized"));
  }

  private char FindCommonCharInThree(int i)
  {
   var first = Rucksacks[i].Compartment1.Union(Rucksacks[i].Compartment2).ToList();
   var second = Rucksacks[i + 1].Compartment1.Union(Rucksacks[i + 1].Compartment2).ToList();
   var third = Rucksacks[i + 2].Compartment1.Union(Rucksacks[i + 2].Compartment2).ToList();
   var commonChar = first.Where(c => second.Contains(c)).Where(c => third.Contains(c)).ToList();
   return commonChar.First();
  }
 }
}