using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signletone
{
    public sealed class LazySingletone
    {
        //lazy loading
        private LazySingletone()
        {
        }
        private static readonly Lazy<LazySingletone> _lazy=new Lazy<LazySingletone>(()=>new LazySingletone());
        public static LazySingletone Instance
        {
            get
            {
                return _lazy.Value;
            }
           
        }
    }
}
