using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
    class DiceGame:Player
    {
        
        int id;
        int number;
        int dices;
        public DiceGame(int id,int dices):base(id,dices)
        {
            this.id = id;
            this.number = number;
            this.dices = dices;
        }
        
        public void InitGame()
        {
            DiceRoller diceRoller = new DiceRoller();
            int x=diceRoller.DiceCount();
            Random rnd = new Random();
            int players = rnd.Next(2,7);
            List<Player> player = new List<Player>();
            for (int i = 1; i<=players; i++)
            {
               player.Add(new Player(id, x));
               
            }

            foreach (object group in player)
            {
                Console.WriteLine(group);
            }
        }
    }
}
