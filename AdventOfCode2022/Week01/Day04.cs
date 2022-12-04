namespace AdventOfCode2022.Week01
{
  internal class Day04
  {
    public int CommonAreasCounter { get; set; }
    public int IntersectCounter { get; set; }
    public Day04(string[] input)
    {
      CommonAreasCounter = 0;
      IntersectCounter = 0;
      foreach (var line in input)
      {
        var parts = line.Split(',');
        List<int> part1List = GetAreasInPart(parts[0]);
        List<int> part2List = GetAreasInPart(parts[1]);
        var commonAreas = part1List.Intersect(part2List).Count() == part2List.Count;
        if (!commonAreas)
        {
          commonAreas = part2List.Intersect(part1List).Count() == part1List.Count;
        }
        if (commonAreas) CommonAreasCounter++;
        if (part1List.Intersect(part2List).Count() > 0) IntersectCounter++;
      }
    }

    private List<int> GetAreasInPart(string parts)
    {
      // Parts has format "2-8"
      var subParts = parts.Split('-');
      var list = new List<int>();
      for (var i = int.Parse(subParts[0]); i <= int.Parse(subParts[1]); i++)
      {
        list.Add(i);
      }
      return list;
    }
  }
}
