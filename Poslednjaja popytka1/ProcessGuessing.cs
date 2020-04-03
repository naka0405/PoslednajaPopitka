
using System;
using System.Collections.Generic;

namespace Poslednjaja_popytka
{
    public class ProcessGuessing
    {
        public static List<ProcessGuessing> allPlayersAndGuessings = new List<ProcessGuessing>();
        public BasePlayer Player { get; set; }

        public int Weight { get; set; }

        public ProcessGuessing(BasePlayer player, int weight)
        {
            Player = player;
            Weight = weight;
        }

        public override string ToString()
        {
            //return Player.ToString();
            return $"{Player.TypeOfPlayer} WIN {Weight}!!!!!";

        }

        public void PrintInfo2()
        {
            Console.WriteLine(ToString());
        }
    }
}
