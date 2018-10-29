using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {
        
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            
            a_dealer.DealCardFromDeck(true, a_player);
            a_dealer.DealCardFromDeck(true, a_dealer);
            a_dealer.DealCardFromDeck(true, a_player);

            return true;
        }
    }
}
