using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    interface IHitStrategy
    {
        bool DoHit(model.Player a_dealer);
    }
}
