using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Weapon
{
    class Axe : AbstractCloseWeapon
    {
        public override void Attack()
        {
            Console.WriteLine("Axe attace");
        }
    }
}
