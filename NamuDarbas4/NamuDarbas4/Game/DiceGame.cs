using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamuDarbas4.Game
{
    class DiceGame:Player
    {
        
        int id;
        int number;
        int dices;
        int score;
        public DiceGame(int id,int dices, int score):base(id,dices,score)
        {
            this.id = id;
            this.number = number;
            this.dices = dices;
            this.score = score;
        }
        public List<Player> player = new List<Player>();

        DiceRoller diceRoller = new DiceRoller();
        int rollerCount;
        public void InitGame()
        {
             rollerCount = diceRoller.DiceCount();
            Random rnd = new Random();
            int players = rnd.Next(2,7);
            
            for (int i = 1; i<=players; i++)
            {
                int playerScore = 0;
                for (int y = 1; y <= rollerCount; y++)
                      {
                          playerScore += rnd.Next(1, 6);
                      }
                    player.Add(new Player(id=id,dices= rollerCount,score=playerScore));
                

               // player.Where(p => p.score = 0).FirstOrDefault().score = playerScore;
            }

            foreach (object group in player)
            {
                Console.WriteLine(group);
            }
            Console.WriteLine("-------------");
            
        }

        public void Game()
        {
            Random rnd = new Random();
           

            // foreach (object group in player)
            // {
            //     for(int i=1; i<=rollerCount; i++)
            //     {
            //         playerScore += rnd.Next(1, 6);
            //     }
            //     
            // }

        }
    }
}
