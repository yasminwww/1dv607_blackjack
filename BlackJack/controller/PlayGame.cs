using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controller
{
    class PlayGame : IGamePauser, model.IObserver
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

            EnumChoise.InputType input = a_view.GetInput();

            if (input == EnumChoise.InputType.Play)
            {
                a_game.m_player.RegisterSubscriber(this);
                a_game.m_dealer.RegisterSubscriber(this);
                a_game.NewGame();
            }
            else if (input == EnumChoise.InputType.Hit)
            {
                a_game.Hit();
            }
            else if (input == EnumChoise.InputType.Stand)
            {
                a_game.Stand();
            }
            // 
            return input != EnumChoise.InputType.Quit;
        }
        public void PauseGame()
        {
            System.Threading.Thread.Sleep(1500);
        }

        public void DisplayGame() 
        {
            PauseGame();
            a_view.DisplayWelcomeMessage();
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
        }

        public void Update() 
        {
            DisplayGame();
        }

    }
}
