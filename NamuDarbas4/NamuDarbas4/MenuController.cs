using NamuDarbas4.Game;
using NamuDarbas4.Gui;
using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4
{
    class MenuController
    {
        GameWindow gameWindow = new GameWindow();
        PlayerWindow playerWindow = new PlayerWindow();
        DiceWindow diceWindow = new DiceWindow();
        DiceRoller dice = new DiceRoller();

        public void Controller()
        {
            int x = 0;
            gameWindow.Render();
            while (x == 0)
            {                
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.Q:
                        x = 1;
                        break;
                    case ConsoleKey.P:
                        x = 2;
                        break;                  
                }
            }

            if (x == 1)
            {
                Console.Clear();
                return;

            }
            else if( x==2 )
            {                
                playerWindow.Render();
            }
            else throw new System.Exception("Klaida, kas per mygtukas?");

            if (playerWindow.PWKey == 1)
            {
                playerWindow.PlayerCount();
                
            }
            else if (playerWindow.PWKey == 2) Controller();
            else throw new System.Exception("Klaida zaideju kiekio lenteleje?");

            diceWindow.Render();
            if (dice.DRKey == 1) ;
            else if (dice.DRKey == 2) Controller();
            else throw new System.Exception("Klaida kauliuku kiekio WIndow?");
        }
    }
}
