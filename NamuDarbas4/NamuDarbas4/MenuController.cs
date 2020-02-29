using NamuDarbas4.Game;
using NamuDarbas4.Gui;
using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4
{
    class MenuController
    {
        MenuWindow menuWindow = new MenuWindow();
        PlayerWindow playerWindow = new PlayerWindow();
        DiceWindow diceWindow = new DiceWindow();
        DiceRoller diceRoller = new DiceRoller();
        DiceGame diceGame = new DiceGame();


        public static string Winner = "No Winner";

        public void Controller()
        {
            int controller = 0;
            int playerW = 0;
            int menu = 0;
            playerWindow.PWKey = 0;
            while (controller == 0 || controller==1)
            {
                 playerW = 0;
                DiceRoller.DRKey = 0;

                while (DiceRoller.DRKey == 0)
                {

                while (playerW == 0)
                {
                    playerWindow.PWKey = 0;
                        if (controller == 0)
                        {
                            menu = 0;
                            menuWindow.Render();
                            while (menu == 0)
                            {
                                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                                switch (pressedChar.Key)
                                {
                                    case ConsoleKey.Q:
                                        menu = 1;
                                        break;
                                    case ConsoleKey.P:
                                        menu = 2;
                                        break;
                                }
                            }

                            if (menu == 1)
                            {
                                Console.Clear();
                                return;
                            }

                            else if (menu != 2) throw new System.Exception("Klaida, kas per mygtukas?");
                        }


                    playerWindow.Render();

                    if (playerWindow.PWKey == 1) break;
                    else if (playerWindow.PWKey == 2) ;
                    else throw new System.Exception("Klaida zaideju kiekio lenteleje?");
                }

                playerWindow.PlayerCount();

                diceWindow.Render();

                if (DiceRoller.DRKey == 1) Console.Clear();
                else if (DiceRoller.DRKey == 2)
                {
                        DiceRoller.DRKey = 0;
                        controller = 1;
                }
                else throw new System.Exception("Klaida kauliuku kiekio Window?");
            }

                while (diceGame.InitGame(diceWindow.Dices, playerWindow.PlayerCount()) == 2) ;
                
                Console.ReadKey();

                GameOverWindow gameOverWindow = new GameOverWindow(Winner);
                gameOverWindow.Render();
                
                
                    if (GameOverWindow.GOWKey == 1)
                    {
                        Console.Clear();
                        return;
                    }
                    else if (GameOverWindow.GOWKey == 2)
                    {
                        controller = 1;
                        diceWindow.Dices = 0;
                        Player.DiceId = 1;
                        DiceGame.player.Clear();
                    }
                    else if (GameOverWindow.GOWKey == 3)
                    {
                        controller = 0;
                        diceWindow.Dices = 0;
                        Player.DiceId = 1;
                        DiceGame.player.Clear();
                    }
                             
            }
        }
    }
}
