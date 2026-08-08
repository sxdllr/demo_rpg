using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_rpg.GameSystem
{
    public class HP
    {
        private ushort _maxHP;

        public HP(ushort startingMaxHP)
        {
            MaxHP = startingMaxHP;
            CurrentHP = startingMaxHP;
        }

        public ushort MaxHP 
        {
            get { return _maxHP; }
            set 
            {
                if (value >= 1) 
                {
                    _maxHP = value;
                    if (CurrentHP > _maxHP) 
                        CurrentHP = _maxHP;
                }   
            }
        }

        public ushort CurrentHP { get; private set; }

        public void TakeDamage(ushort damage) 
        {
            if (damage > CurrentHP)
            {
                CurrentHP = 0;
                return;
            }

            CurrentHP -= damage;
        }

        public void Heal(ushort amount) 
        {
            if (amount + CurrentHP > MaxHP )
            { 
                CurrentHP = MaxHP;
                return;
            }

            CurrentHP += amount;
        }
    }
}
