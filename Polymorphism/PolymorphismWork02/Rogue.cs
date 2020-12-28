using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) 
            : base(name)
        {
        }

        public override string CastAbility()
        {
            throw new NotImplementedException();
        }
    }
}
