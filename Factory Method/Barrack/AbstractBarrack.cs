using Factory_Method.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Barrack
{
    public abstract class AbstractBarrack
    {
        public abstract AbstractCloseWeapon TakeCloseWeapon();
        public abstract AbstractDistanceWeapon TakeDistanceWeapon();
    }
}
