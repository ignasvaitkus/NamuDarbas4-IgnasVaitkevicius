using NamuDarbas4.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamuDarbas4.Game
{
    class DiceGame
    {
        public static int GamesCount = 1;
        int id;
        int number;
        int dices;
        int score;
        
        static int Sum = 0;
       public static List<Player> player = new List<Player>();

       
       
        public int InitGame(int dice, int players)
        {
            
            Console.WriteLine("Match nr." + GamesCount);
            Random rnd = new Random();          
            
            for (int i = 1; i<=players; i++)
            {
                int playerScore = 0;
                for (int y = 1; y <= dice; y++)
                      {
                          playerScore += rnd.Next(1, 6);
                      }
                
                    player.Add(new Player(id=i, dices=dice, score=playerScore));
                Console.WriteLine(player[i-1]);
                
            }
            
            Console.WriteLine("-------------");
            
            int key = 0;            
           int maxScore = 0;
            
           for (int i = 0; i <= players-1; i++)
           {
                if (player[i].Score > maxScore)
                {
                    maxScore = player[i].Score;
                                      
                       MenuController.Winner = player[i].ToString();
                    
                  
                }
           }
           
           for (int i = 0; i <= players-1; i++)
           {
               if (player[i].Score == maxScore) key++;
               if(key==2)
               {                       
                           player.Clear();
                    Player.DiceId = 1;
                    GamesCount++;
                   break;
               }
           }
            
           Sum = maxScore;
            
            
            return key;
            
        }

        
    }
}
