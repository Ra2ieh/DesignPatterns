using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signletone
{
    public sealed class StaticCons
    {
        private StaticCons()
        {

        }

        private static readonly StaticCons _instance = new StaticCons();
        public static StaticCons Instance { get { return _instance; } }
    }

    //The preceding implementation looks like a very simple code.
    //This type of implementation has a static constructor, so it executes only once per Application Domain.

}
