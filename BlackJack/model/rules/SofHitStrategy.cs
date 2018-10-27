using System.Linq;

namespace model.rules {
        class SoftHitStrategy : IHitStrategy
    {
        public bool DoHit(model.Player a_dealer)
        {
            // Om äss, och summan av handen är 17
            bool isSoft17 = a_dealer.CalcScore() == 17 && a_dealer.GetHand().Any(card => card.GetValue() == Card.Value.Ace);
            return isSoft17 || a_dealer.CalcScore() < 17;
        }
    }
}
