namespace model.rules
{
    interface IWinnnerStrategy
    {
        bool IsDealerWinner(Player a_player, Dealer a_dealer, int g_maxScore);
    }
}