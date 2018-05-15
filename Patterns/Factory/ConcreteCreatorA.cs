using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>

    class ConcreteCreatorA : Creator

    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

}
