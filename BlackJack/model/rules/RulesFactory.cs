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
            return new SoftHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
    }
}
