using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/decorator-design-pattern
/// TYPE: Structural Patterns
/// DEFINITION: Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
/// </summary>

namespace Decorator
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Decorator Design Pattern.
    /// </summary>

    class MainApp

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Create ConcreteComponent and two Decorators

            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user

            Console.ReadKey();
        }
    }
}
