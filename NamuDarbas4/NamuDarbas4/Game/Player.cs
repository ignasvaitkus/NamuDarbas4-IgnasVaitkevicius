using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
    class Player
    {
        static private int DiceId = 1;
        public int Id{get;}
        public int Number { get; set; }

        public Player(int id, int number)
        {
            Id = id;
            Number = number;
            Id = DiceId++;
        }
        public override string ToString()
        {
            return $"Student {Id}: {Number} ";
        }
    }
}
