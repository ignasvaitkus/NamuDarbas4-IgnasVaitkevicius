using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
    class DiceRoller
    {
        int diceCount = 3;
        

        public int DiceCount()
        {
            int x = 0;
            while (x!=1)
            {
                Console.WriteLine("Players will have: "+diceCount+" dice");
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:
                        x = 1;
                        break;
                    case ConsoleKey.OemPlus:
                        diceCount++;
                        break;
                    case ConsoleKey.OemMinus:
                        if(diceCount!=1) diceCount--;
                        break;
                }
                
            }
            return diceCount;
        }
    }

   
}
