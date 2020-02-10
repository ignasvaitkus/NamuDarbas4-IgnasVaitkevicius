using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Gui
{
    sealed class PlayerWindow : Window
    {
        public int PlayerAmount { get; private set; } = 0;
        GameWindow gameWindow = new GameWindow();
        DiceWindow diceWindow=new DiceWindow();
        Button button;
        private Button P2;
        private Button P3;
        private Button P4;
        private Button P5;
        private Button P6;
        private Button P7;
        public int PWKey { get; private set; } = 0;

        public PlayerWindow() : base(0, 0, 120, 30, '%')
        {
            P2 = new Button(43, 5,10, 5, "P2");
            P3 = new Button(63, 5, 10, 5, "P3");
            P4 = new Button(43, 13, 10, 5, "P4");
            P5 = new Button(63, 13, 10, 5, "P5");
            P6 = new Button(43, 21, 10, 5, "P6");
            P7 = new Button(63, 21, 10, 5, "P7");
            P2.SetActive();
            
        }

        public int PlayerCount()
        {
            if(P2.ActiveCheck()) return PlayerAmount=2;
            if(P3.ActiveCheck()) return PlayerAmount=3;
            if(P4.ActiveCheck()) return PlayerAmount=4;
            if(P5.ActiveCheck()) return PlayerAmount=5;
            if(P6.ActiveCheck()) return PlayerAmount=6;
            if(P7.ActiveCheck()) return PlayerAmount=7;
            else return 0;
        }

        public override void Render()
        {
            Console.SetCursorPosition(0, 0);
            while (PWKey == 0)
            {
                base.Render();
                P2.Render();
                P3.Render();
                P4.Render();
                P5.Render();
                P6.Render();
                P7.Render();

                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:
                        PWKey = 1;
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        PWKey = 2;
                        break;

                    case ConsoleKey.UpArrow:
                        if (P4.ActiveCheck()) { P4.SetInActive(); P2.SetActive(); }
                        if (P5.ActiveCheck()) { P5.SetInActive(); P3.SetActive(); }
                        if (P6.ActiveCheck()) { P6.SetInActive(); P4.SetActive(); }
                        if (P7.ActiveCheck()) { P7.SetInActive(); P5.SetActive(); }                       
                        break;

                    case ConsoleKey.DownArrow:
                        if (P4.ActiveCheck()) { P4.SetInActive(); P6.SetActive(); }
                        if (P5.ActiveCheck()) { P5.SetInActive(); P7.SetActive(); }
                        if (P2.ActiveCheck()) { P2.SetInActive(); P4.SetActive(); }
                        if (P3.ActiveCheck()) { P3.SetInActive(); P5.SetActive(); }
                        break;

                    case ConsoleKey.RightArrow:
                        if (P2.ActiveCheck()) { P2.SetInActive(); P3.SetActive(); }
                        if (P4.ActiveCheck()) { P4.SetInActive(); P5.SetActive(); }
                        if (P6.ActiveCheck()) { P6.SetInActive(); P7.SetActive(); }                     
                        break;

                    case ConsoleKey.LeftArrow:
                        if (P3.ActiveCheck()) { P3.SetInActive(); P2.SetActive(); }
                        if (P5.ActiveCheck()) { P5.SetInActive(); P4.SetActive(); }
                        if (P7.ActiveCheck()) { P7.SetInActive(); P6.SetActive(); }
                        break;
                }
            }

            
          
          
          
          
          
          
        }
    }
}
