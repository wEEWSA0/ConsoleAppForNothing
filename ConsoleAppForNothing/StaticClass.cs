using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForNothing
{
    internal class StaticClass
    {
        const string Name = "static";

        public static string GetName()
        {
            return Name;
        }
    }
}
