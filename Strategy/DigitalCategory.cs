using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DigitalCategory : ICategory
    {
        public string _name => "Digital";

        public string GetName()
        {
           return _name;
        }

    }
}
