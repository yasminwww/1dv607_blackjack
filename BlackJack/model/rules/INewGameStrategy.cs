using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    interface INewGameStrategy
    {
        bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player);
    }
}
