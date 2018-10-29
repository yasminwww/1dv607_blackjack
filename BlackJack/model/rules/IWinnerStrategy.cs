using System;

namespace model.rules
{
    interface IWinnerStrategy
    {
        bool IsDealerWinner(Player a_player, Dealer a_dealer, int g_maxScore);
    }
}