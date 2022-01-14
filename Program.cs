using System.Linq;
using System.Collections.Generic;
using System;
using System.IO;

namespace DataSamlingsBot
{
    class Program
    {
        List<Board> ListOfGames = new List<Board>();
        static void Main(string[] args)
        {

        }
        static void simulator(string drag)
        {//brädet 

            //Follow instructions from the pgnreader
        }
        static void PGNReader()
        {
            int z = 1;
            int i = 1;
            int y = 1;
            List<string> PgnSamling = new List<string>();
            List<int> GameStartValues = new List<int>();
            List<int> GameEndValues = new List<int>();
            List<string> PlayedGames = new List<string>();
            //hitta filen
            PgnSamling = File.ReadAllLines("./Akobian.pgn").ToList();
            //hittar när partiet börjar och slutar
            //Läsa partiet
            //how to find 1.and then 
            //if partistart > partislut(behöver fortfarande använda read file)
            foreach (var item in PgnSamling)
            {
                //Hitta 1. och resulat med hjälp av index 
                i++;
                PgnSamling.ToArray();
                string line = PgnSamling[int.Parse(item)];
                if (line == "1.")
                {
                    z++;
                    GameEndValues.Add(line.IndexOf("1.", 0, i));
                }
                else if (line == "0-1")
                {
                    y++;
                    GameEndValues.Add(line.IndexOf("0-1", 0, i));
                }
                else if (line == "1-0")
                {
                    y++;
                    GameEndValues.Add(line.IndexOf("1-0", 0, i));
                }
                else if (line == "1/2-1/2")
                {
                    y++;
                    GameEndValues.Add(line.IndexOf("1/2-1/2", 0, i));
                }
            }
            //Gå igenom pgnsamling efter man vet vart partierna är
            //1.=line 20 0-1=line 40 loops 20 times and adds the lines containing the moves to PlayedGames
            for (var a = 0; a < PgnSamling.Count(); a++)
            {
                for (int b = GameStartValues.Count(); b < GameEndValues.Count(); b++)
                {
                    PlayedGames.Add(PgnSamling[b]);
                }
            }
        }
        static void Calculator()
        {
            Game statistic = new Game();
        }
    }
}
