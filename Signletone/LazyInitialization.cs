using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signletone
{
    //The following code is not thread-safe.
    //Two different threads could both have evaluated the test(if instance == null) and found it to be true, then both create instances, which violates the singleton pattern.
    public sealed class LazyInitialization
    {
        private static LazyInitialization _id=null;
        private LazyInitialization()
        {

        }
        public LazyInitialization GetInstance() { 
            if( _id == null ) 
            { 
                _id = new LazyInitialization(); 
            } 
            return _id; 
        }
    }
}
