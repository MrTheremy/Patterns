using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>

    class RefinedAbstraction : Abstraction

    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
