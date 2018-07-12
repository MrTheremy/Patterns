using System;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/proxy-design-pattern
/// TYPE: Structural Patterns
/// DEFINITION: Provide a surrogate or placeholder for another object to control access to it.
/// </summary>

namespace Proxy
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Proxy Design Pattern.
    /// </summary>

    class MainApp

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Create proxy and request a service

            Proxy proxy = new Proxy();
            proxy.Request();

            // Wait for user

            Console.ReadKey();
        }
    }
}
