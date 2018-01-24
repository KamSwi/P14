using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141163
{
    class Elf : Bohater
    {
        private string magia;

        public Elf(int hp, string magia)
            : base(hp)
        {
            this.magia = magia;
        }

        public override bool ZadajCios(int hp)
        {
            this.hp -= hp;
            if (hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
    }

    }
        }
    
