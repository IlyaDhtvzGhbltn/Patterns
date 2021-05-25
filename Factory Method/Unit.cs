using Factory_Method.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Unit
    {
        public Unit(Barrack.AbstractBarrack barrack)
        {
            CloseWeapon = barrack.TakeCloseWeapon();
            DistanceWeapon = barrack.TakeDistanceWeapon();
        }

        AbstractCloseWeapon CloseWeapon;
        AbstractDistanceWeapon DistanceWeapon;

        public void DistanceAttack() 
        {
            this.DistanceWeapon.Attack();
        }
        public void CloseAttack() 
        {
            this.CloseWeapon.Attack();
        }
    }
}
