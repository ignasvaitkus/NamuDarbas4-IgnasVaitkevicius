using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
     class Player
    {
        public static int DiceId = 1;
        public int Id;
        public int Number { get; set; }
        public int Score { get; set; }
        public int Dices { get; set; }

        public Player(int id,int dices, int score)
        {
            Dices = dices;    
            Score = score;           
            Id = DiceId++;       

        }
        public override string ToString()
        {
            return $"Player {Id}: Has {Dices} dices with score {Score} ";
        }

        
    }
}
