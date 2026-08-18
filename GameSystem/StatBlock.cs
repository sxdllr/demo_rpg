using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_rpg.GameSystem
{
    public struct StatBlock
    {
        public ushort Strength { get; set; }

        public ushort Intelligence { get; set; }

        public StatBlock(ushort strength = 1, ushort intelligence = 1)
        {
            Strength = strength;
            Intelligence = intelligence;
        }

    }
}
