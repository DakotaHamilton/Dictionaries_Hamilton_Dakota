using System;
using System.Collections;
using System.Collections.Generic;
namespace Dictionaries_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary List
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Goddess Of Victory: NIKKE");
            topGames.Add(2, "Team Fortress 2");
            topGames.Add(3, "Fortnite");
            topGames.Add(4, "Overwatch");
            topGames.Add(5, "Monster Hunter World");
            topGames.Add(6, "COD: Black Ops");
            topGames.Add(7, "COD: Black Ops II");
            topGames.Add(8, "COD: Modern Warfare 3");
            topGames.Add(9, "Halo 3: ODST");
            topGames.Add(10, "DOOM (1993)");

            // Prints each Object from the List to the Console
            foreach(KeyValuePair<int, string> kvp in topGames) 
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Prints Object Number 1 to the Console
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"\nMy favorite game is: {topGames[1]}");
            }

            // Checks if there is an Eleventh Object and if not Replaces Object 5 with Another game
            string result = "";
            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Saints Row IV";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);
            
            string FavGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: {FavGame}");

            // New Hashtable
            Hashtable capitals = new Hashtable()
            {
                {"Oklahoma", "Oklahoma City" },
                {"New York", "Albany" },
                {"Texas", "Austin" },
                {"Ohio", "Columbus" }
            };

            // Prints each Object from the List to the Console
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Clears the List
            capitals.Clear();
        }
    }
}
