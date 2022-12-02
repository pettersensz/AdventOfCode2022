using System.IO;

namespace AdventOfCode2022.Shared
{
  public static class ReadFile
  {
    public static string[] ReadLinesInTextFile(string filename)
    {
      var directory = Directory.GetCurrentDirectory();
      var path = Path.GetFullPath(Path.Combine(directory, @"..\..\..\Input\" + filename));

      var fileData = File.ReadAllLines(path);
      return fileData;
    }
  }
}
