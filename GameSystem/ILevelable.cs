using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_rpg.GameSystem
{
    public interface ILevelable
    {
        ushort CurrentLVL { get; }
        UInt32 CurrentEXP { get; }
        UInt32 EXPtoNextLVL { get; }
        bool IsLevelable { get; }

        void GainEXP(UInt32 gainedEXP);
    }
}
