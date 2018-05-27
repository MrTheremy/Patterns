using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/bridge-design-pattern
/// TYPE: Structural Patterns
/// DEFINITION: Decouple an abstraction from its implementation so that the two can vary independently.
/// </summary>

namespace Bridge
{
    /// <summary>

    /// MainApp startup class for Structural

    /// Bridge Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user

            Console.ReadKey();
        }
    }
}
