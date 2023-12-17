using System;
using System.IO;


namespace utils
{
    static class fileManager
    {
       public static string[] readAll(string filePath)
        {
            string[] fileLines = null;
            if (File.Exists(filePath))
            {
                fileLines= File.ReadAllLines(filePath);
            }
            else
            {
                Console.WriteLine(@"file does not exist {filePath}");
            }
            return fileLines;
        }

        public static void writeAll(string[] lines,string filePath)
        {
         
            if (lines.Length>0)
            {
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                Console.WriteLine("empty string array!");
            }
        }
    }
}