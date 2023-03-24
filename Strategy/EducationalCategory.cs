using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EducationalCategory : ICategory
    {
        public string _name => "Educational";

        public string GetName()
        {
            return $"my name is {_name}";
        }
    }
}
