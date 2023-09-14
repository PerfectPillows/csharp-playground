using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.playground
{
    public class MultipleInterface : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.display() {
            Console.WriteLine("Method overriden from IInterfaceA");
        }

        void IInterfaceB.display()
        {
            Console.WriteLine("Method overriden from IInterfaceB");
        }

    }
}
