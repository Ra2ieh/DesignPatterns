using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class XmlDocument : Document
    {
        public override void PrintBody()
        {
            Console.WriteLine("Xml Body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("Xml Footer");
        }

        public override void PrintHeader()
        {
            Console.WriteLine("Xml Header");
        }
    }
}
