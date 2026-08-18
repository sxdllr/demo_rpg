using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo_rpg.GameSystem;

namespace demo_rpg.Entities
{
    public class Wizard
    {
        public const ushort BASESTR = 1;
        public const ushort BASEINT = 5;
        public const ushort HPGROWTH = 2;

        public HP Health { get; private set; }
        public StatBlock Stats { get; private set; }

        public Wizard()
        {
            Health = new HP(HPGROWTH, HPGROWTH);
            Stats = new StatBlock(strength: BASESTR, intelligence: BASEINT);
        }
    }
}
