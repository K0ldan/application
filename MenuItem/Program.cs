using ConsoleApp2.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string,string> argsDic = CmdArgsParser.Parse(args);
            IOUtils.SetExtValues(argsDic);

            Menu2.ClearItem();
            Menu2.AddItem(new Exit());
            Menu2.AddItem(new HelloWorld());
            Menu2.AddItem(new Calcul());
            Menu2.AddItem(new Stringi());
            Menu2.AddItem(new DateRec());

            if (argsDic != null)
            {
                try
                {
                    Menu2.Execute();
                }
                catch (InvalidOperationException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                while(true)
                {
                    Menu2.ShowMenu();
                    Menu2.Execute();
                }
            }
        }   
        
    }
}
