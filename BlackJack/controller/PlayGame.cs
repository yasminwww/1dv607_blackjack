using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controller
{
    class PlayGame : model.ICardObserver
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

            EnumChoice.GameChoice input = a_view.GetInput();

            if (input == EnumChoice.GameChoice.Play)
            {
                a_game.m_player.RegisterSubscriber(this);
                a_game.m_dealer.RegisterSubscriber(this);
                a_game.NewGame();
            }
            else if (input == EnumChoice.GameChoice.Hit)
            {
                a_game.Hit();
            }
            else if (input == EnumChoice.GameChoice.Stand)
            {
                a_game.Stand();
            }
            // 
            return input != EnumChoice.GameChoice.Quit;
        }
        public void PauseGame()
        {
            System.Threading.Thread.Sleep(1000);
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
