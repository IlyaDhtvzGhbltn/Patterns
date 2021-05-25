using Factory_Method.Barrack;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Unit warrior = new Unit(new RebelBarrack());
            warrior.CloseAttack();
            warrior.DistanceAttack();

            Console.Read();
        }
    }
}
