using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class HtmlDocument : Document
    {
        public override void PrintBody()
        {
           Console.WriteLine("Html Body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("Html Footer");
        }

        public override void PrintHeader()
        {
            Console.WriteLine("Html Header");
        }
    }
}
