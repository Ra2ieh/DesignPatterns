using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signletone
{
    public sealed class DoubleCheckedSingletone
    {
        private static DoubleCheckedSingletone _instance;
        private static readonly object _lock = new object();
        DoubleCheckedSingletone() { }
        public static DoubleCheckedSingletone Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new DoubleCheckedSingletone();
                    }
                }
                return _instance;
            }
        }
    }

    //In the following code, the thread is locked on a shared object and checks whether an instance has been created or not with double checking.
}
