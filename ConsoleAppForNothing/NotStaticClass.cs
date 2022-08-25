using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForNothing
{
    internal class NotStaticClass
    {
        const string Name = "not static";

        public string GetName()
        {
            return Name;
        }
    }
}
