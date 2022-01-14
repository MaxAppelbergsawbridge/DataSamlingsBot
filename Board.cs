using System;

namespace DataSamlingsBot
{
    public class Board
    {
        //write piece names? 
        public string R = "";
        public string B = "";
        public string N = "";
        public string Q = "";
        public string K = "";
        public string P = "";
        public string O = "";
        public string[,] VirBoard =
       {/*
            Titta på list inom list
            */
                {"R","B","N","Q","K","N","B","R"},
                {"P","P","P","P","P","P","P","P"},
                {"O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O"},
                {"P","P","P","P","P","P","P","P"},
                {"R","B","N","Q","K","N","B","R"}
    };
    }
}

