using System;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/facade-design-pattern
/// TYPE: Structural Patterns
/// DEFINITION: Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.
/// </summary>

namespace Facade
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>

    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        public static void Main()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user

            Console.ReadKey();
        }
    }
}
