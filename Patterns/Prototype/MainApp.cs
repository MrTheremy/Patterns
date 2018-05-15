
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/prototype-design-pattern
/// TYPE: Creational
/// DEFINITION: Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
/// </summary>

namespace Prototype
{
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Create two instances and clone each


            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user

            Console.ReadKey();
        }
    }
}
