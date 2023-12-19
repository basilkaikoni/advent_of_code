using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utils;

namespace advent_of_code
{
    public static  class Day2
    {
        static uint maxNumberOfRedCubes = 12;
        static uint maxNumberOfGreenCubes = 13;
        static uint maxNumberOfBlueCubes = 14;
        public static void run()
        {
            Console.WriteLine(parseGames());
        }

        private static uint parseGames() {
            uint sumOfSuccessfullGamesIDS = 0;
            string[] lines = fileManager.readAll(@"C:\\Users\\user\\Desktop\\1.txt");
            
            foreach (string line in lines)
            {
                if (parseGame(line))
                {
                    uint gameID = Convert.ToUInt16(line.Substring(line.IndexOf("Game") + 5).Split(':')[0]);
                    sumOfSuccessfullGamesIDS+= gameID;
                }
            }
                return sumOfSuccessfullGamesIDS;
        }
        private static bool parseGame(string game)
        {
            bool result = false;
            string[] gamePicks=game.Substring(game.IndexOf(':')+1).Split(';');
            foreach(string pick in gamePicks)
            {
                string [] pickColors = pick.Split(',');
                uint greenCount, blueCount, redCount;
                greenCount = blueCount = redCount = 0;
                foreach (string pickColor in pickColors)
                {
                    if (pickColor.Contains("red"))
                    {
                        redCount+=Convert.ToUInt16(pickColor.Remove(pickColor.IndexOf("red")-1));
                    }
                    else if(pickColor.Contains("green"))
                    {
                        greenCount += Convert.ToUInt16(pickColor.Remove(pickColor.IndexOf("green") - 1));
                    }
                    else if (pickColor.Contains("blue"))
                    {
                        blueCount += Convert.ToUInt16(pickColor.Remove(pickColor.IndexOf("blue") - 1));
                    }
                }
                result = (greenCount <= maxNumberOfGreenCubes && redCount <= maxNumberOfRedCubes && blueCount <= maxNumberOfBlueCubes);
                if (!result) break;
            }
            return result;

        }

    }
}
