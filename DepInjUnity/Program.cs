using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DepInjUnity.Implementation;
using Unity;

namespace DepInjUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ILogger redLoger = new RedLogger();
                redLoger.Write("This is NOT CORRECT Dependency Injection!");
            */
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, ConsoleLogger>();

            var logger = container.Resolve<ILogger>();
            logger.Write("Yeaaaa!");

            Console.ReadKey();
        }
    }
}
