using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utils;

namespace advent_of_code
{
    static class Day1
    {
        static string GetFirstandLastDigitsFromString(string input)
        {
            string result = "";
            if (input.Length > 0)
            {
                string onlyDigitsString = new string(input.Where(c => char.IsDigit(c)).ToArray());
                result = onlyDigitsString[0].ToString();
                result += onlyDigitsString[onlyDigitsString.Length - 1].ToString();
            }
            return result;
        }

        public static void run()
        {
            string[] lines = fileManager.readAll(@"C:\\Users\\user\\Desktop\\1.txt");
            int result = 0;
            foreach (string line in lines)
            {
                string firstAndlastDigitString=GetFirstandLastDigitsFromString(line);
                result += Convert.ToInt32(firstAndlastDigitString);
            }
            Console.WriteLine(result);
        }

    }
}
