using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            // return new BasicHitStrategy();
            return new SoftHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            // return new InternationalGameStrategy();
            return new AmericanNewGameStrategy();
        }
        
        public IWinnerStrategy GetWinRule()
        {
            // return new PlayerWinsStrategy();
            return new DealerWinsStrategy();
        }
    }
}
