﻿using NamuDarbas4.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbas4.Gui
{
    sealed class DiceWindow : Window
    {
        DiceRoller dice= new DiceRoller();
        //PlayerWindow playerWindow = new PlayerWindow();

        private Button _startButton;

        
        private TextBlock _titleTextBlock;

        int x = 0;
        
        public int Dices { get;  set; }
        public int Players { get; private set; }
        public DiceWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { });

            _startButton = new Button(45, 13, 30, 5, $"Players will have dice: {dice.diceCount} ");




            
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();            

            while (DiceRoller.DRKey == 0)
            {
                _startButton = new Button(45, 13, 30, 5, $"Players will have dice: {dice.diceCount} ");
                _startButton.Render();
                Dices=dice.DiceAmount();  
               
            }
            
            
            //Players = playerWindow.PlayerCount();          
        }

    }
}
