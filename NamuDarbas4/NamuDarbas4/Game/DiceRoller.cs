using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Game
{
    class DiceRoller
    {
        public int diceCount { get; private set; } = 3;
        public int DRKey { get; private set; } = 0;

        public void DiceAmount()
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


        }
    }

   
}
