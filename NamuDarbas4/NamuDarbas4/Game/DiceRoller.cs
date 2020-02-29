using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
    class DiceRoller
    {
        public int diceCount = 3;
        public static int DRKey { get; set; } = 0;

        public int DiceAmount()
        {          
            ConsoleKeyInfo pressedChar = Console.ReadKey(true);

            switch (pressedChar.Key)
            {

                case ConsoleKey.OemPlus:
                    diceCount++;
                    break;
                case ConsoleKey.OemMinus:
                    if (diceCount != 1) diceCount--;
                    break;

                case ConsoleKey.Enter:                    
                    DRKey = 1;                    
                    break;

                case ConsoleKey.Escape:
                    DRKey = 2;
                    break;
            }
            return diceCount;

        }

        public int GetDices()
        {
            return diceCount;
        }
    }

   
}
