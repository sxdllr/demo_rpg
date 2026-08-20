using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using demo_rpg.GameSystem;

namespace demo_rpg.Entities
{
    public class Warrior : BaseHero
    {
        public Warrior() : base(hpGrowth: 5, baseStr: 5, baseInt: 1) { }

    }
}
