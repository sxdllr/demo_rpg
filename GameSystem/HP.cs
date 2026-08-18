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

        public HP() : this(currentHP: 1, maxHP: 1) { }

        public HP(ushort currentHP, ushort maxHP)
        {
            _maxHP = maxHP;
            CurrentHP = Math.Min(_maxHP, currentHP);
        }

        public ushort MaxHP 
        {
            get => _maxHP;
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
