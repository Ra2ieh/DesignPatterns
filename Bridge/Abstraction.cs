using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraction
    {
        protected Bridge _implementation;
        public Abstraction(Bridge implementation)
        {
            _implementation = implementation;
        }
        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}
