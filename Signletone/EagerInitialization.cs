using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signletone
{
    public class EagerInitialization
    {
        private static EagerInitialization instance=new EagerInitialization();
        private EagerInitialization()
        {
                
        }

        public static EagerInitialization GetInstance
        {
            get
            {
                return instance;
            }
         
        }
    }
}
