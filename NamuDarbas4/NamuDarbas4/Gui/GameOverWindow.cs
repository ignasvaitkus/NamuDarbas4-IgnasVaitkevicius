using NamuDarbas4.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamuDarbas4.Gui
{
    sealed class GameOverWindow : Window
    {

        DiceGame diceGame = new DiceGame();
        private Button _replayButton;
        private Button _goToMenuButton;
        private Button _quitButton;
        private Button _winnerButton;
        private TextBlock _titleTextBlock;
        public static int GOWKey;

        public GameOverWindow(string winner) : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { });

            _winnerButton = new Button(36, 5, 50, 5, "Winner: " + winner);

            _goToMenuButton = new Button(24, 13, 18, 5, "Menu-M");
            _replayButton = new Button(52, 13, 18, 5, "Replay-R");
            _quitButton = new Button(80, 13, 18, 5, "Quit-Q");
        }

        public override void Render()
        {


            base.Render();

            _titleTextBlock.Render();

            _goToMenuButton.Render();
            _replayButton.Render();
            _winnerButton.Render();
            _quitButton.Render();

            ConsoleKeyInfo pressedChar = Console.ReadKey(true);
            switch (pressedChar.Key)
            {
                case ConsoleKey.Q:
                    GOWKey= 1;
                    break;

                case ConsoleKey.R:
                    Console.Clear();
                    GOWKey= 2;
                    break;
                case ConsoleKey.M:
                    Console.Clear();
                    GOWKey = 3;
                    break;

                default: GOWKey = 0 ;
                    break;
                    
            }
        }

        
    }
}
