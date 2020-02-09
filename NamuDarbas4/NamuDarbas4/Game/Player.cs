using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
    class Player
    {
        static private int DiceId = 0;
        public int Id{get;}
        public int Number { get; set; }
        public int Score { get; set; }
        public int Dices { get; set; }

        public Player(int id,int dices, int score)
        {
            Dices = dices;
            Id = id;
            Score = score;
            Id = DiceId++;
        }
        public override string ToString()
        {
            return $"Player {Id}: Has {Dices} dices with score {Score} ";
        }

        
    }
}
