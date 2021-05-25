using Factory_Method.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Barrack
{
    class WarriorBarack : AbstractBarrack
    {
        public override AbstractCloseWeapon TakeCloseWeapon()
        {
            return new Sword();
        }

        public override AbstractDistanceWeapon TakeDistanceWeapon()
        {
            return new Crossbow();
        }
    }
}
