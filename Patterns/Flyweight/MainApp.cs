using System;

/// <summary>
/// SOURCE: http://www.dofactory.com/net/proxy-design-pattern
/// TYPE: Structural Patterns
/// DEFINITION: Provide a surrogate or placeholder for another object to control access to it.
/// </summary>

namespace Flyweight
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Flyweight Design Pattern.
    /// </summary>

    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Arbitrary extrinsic state

            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            // Wait for user

            Console.ReadKey();
        }
    }
}
