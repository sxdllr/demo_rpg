using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo_rpg.GameSystem;

namespace demo_rpg.Entities
{
    public abstract class BaseHero : ILevelable
    {
        public ushort CurrentLVL { get; protected set; } = 1;
        public UInt32 CurrentEXP { get; protected set; } = 0u;
        public UInt32 EXPtoNextLVL { get; protected set; } = 10;
        public bool IsLevelable { get; protected set; } = false;

        public ushort BaseSTR { get; protected set; }
        public ushort BaseINT { get; protected set; }
        public ushort HPGrowth { get; protected set; }

        public HP Health { get; protected set; }
        public StatBlock Stats { get; protected set; }

        protected BaseHero(ushort hpGrowth, ushort baseStr, ushort baseInt)
        {
            HPGrowth = hpGrowth;
            BaseSTR = baseStr;
            BaseINT = baseInt;

            Health = new HP(HPGrowth, HPGrowth);
            Stats = new StatBlock(strength: BaseSTR, intelligence: BaseINT);
        }

        public virtual void GainEXP(UInt32 gainedEXP) 
        {
            CurrentEXP += gainedEXP;

            if (CurrentEXP >= EXPtoNextLVL) 
            {
                IsLevelable = true;
            }
        }

    }
}
