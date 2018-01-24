using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141163
{
    class Ork : Bohater
    {
        public int walka;

        public Ork(int hp, int walka)
            : base(hp)
        {
            this.walka = walka;
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