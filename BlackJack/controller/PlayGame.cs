using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controller
{
    class PlayGame
    {
        private model.Game a_game;
        private view.IView a_view;
        
        public PlayGame(model.Game agame, view.IView aview)
        {
            this.a_game = agame;
            this.a_view = aview;
        }
        public bool Play()
        {
            DisplayGame();

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            enumtype.InputType input = a_view.GetInput();

            if (input == enumtype.InputType.Play)
            {
                a_game.NewGame();
            }
            else if (input == enumtype.InputType.Hit)
            {
                a_game.Hit();
            }
            else if (input == enumtype.InputType.Stand)
            {
                a_game.Stand();
            }
            // 
            return input != enumtype.InputType.Quit;
        }
        public void DisplayGame() 
        {
            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
        }
    }
}
