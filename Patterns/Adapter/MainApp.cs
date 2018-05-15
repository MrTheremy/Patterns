using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/adapter-design-pattern
/// TYPE: Structural Patterns
/// DEFINITION: Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
/// </summary>

namespace Adapter
{
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Create adapter and place a request

            Target target = new Adapter();
            target.Request();

            // Wait for user

            Console.ReadKey();
        }
    }
}
