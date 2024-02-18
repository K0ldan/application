using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HelloWorld : MenuItemCore
    {
        public override string Title { get { return "Hello World"; } }

        public override void Execute()
        {
            Console.WriteLine("Hello World");
        }
    }
}
