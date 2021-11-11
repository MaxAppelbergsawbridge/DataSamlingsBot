using System.Linq;
using System.Collections.Generic;
using System;
using System.IO;

namespace DataSamlingsBot
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static string simulator(string drag)
        {//brädet 
            string R = "";
            string B = "";
            string N = "";
            string Q = "";
            string K = "";
            string P = "";
            string O = "";
            string[][] Bräd = new string[][]
            {
                {R,B,N,Q,K,N,B,R},
                {P,P,P,P,P,P,P,P},
                {O,O,O,O,O,O,O,O},
                {O,O,O,O,O,O,O,O},
                {O,O,O,O,O,O,O,O},
                {O,O,O,O,O,O,O,O},
                {P,P,P,P,P,P,P,P},
                {R,B,N,Q,K,N,B,R},
            };
        }
        static void PGNReader()
        {
            List<string> PgnSamling = new List<string>();
            //hitta filen
            PgnSamling = File.ReadAllLines("./Akobian.pgn").ToList();
            //hittar när partiet börjar och slutar
            List<int> PartiStart = new List<int>();
            List<int> PartiSlut = new List<int>();
            for (var i = 0; i < PgnSamling.ToArray().Length; i = i + 10)
            {
                int RäkningarStart = PgnSamling.IndexOf("]");
                int RäkningarSlut = PgnSamling.IndexOf("[");
                PartiStart.Add(RäkningarStart);
                PartiSlut.Add(RäkningarSlut);
            }
            //Läsa partiet
            //anse om svart eller vit har gjort ett drag
            //hitta tomma platser
            foreach (int var in PartiStart)
            {
                foreach (int item in PartiSlut)
                {
                    //find int? 
                    //how to find 1.and then 
                }
            }
        }
    }
}
