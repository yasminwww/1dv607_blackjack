using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {

        private void DealCardFromDeck(Deck a_deck, bool show, Player a_player) 
            {
                Card c = a_deck.GetCard();
                c.Show(show);
                a_player.DealCard(c);
            }
        
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            
            DealCardFromDeck(a_deck, true,  a_player);
            DealCardFromDeck(a_deck, true,  a_dealer);
            DealCardFromDeck(a_deck, true,  a_player);

            return true;
        }
    }
}
