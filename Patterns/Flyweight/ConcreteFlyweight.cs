using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>

    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}
