using System;
using System.Collections.Generic;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/builder-design-pattern
/// TYPE: Creational
/// DEFINITION: Separate the construction of a complex object from its representation so that the same construction process can create different representations.
/// </summary>

namespace Builder
{
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        public static void Main()
        {
            // Create director and builders

            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user

            Console.ReadKey();
        }
    }
}
