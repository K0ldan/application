using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Stringi : MenuItemCore
    {
        private ProverString proverka;
        public override string Title { get { return "String"; } }
        public override void Execute()
        {
            proverka = new ProverString();
            string s = IOUtils.SafeReadStr("str1", "Введите s:");
            string h = IOUtils.SafeReadStr("str2", "Введите h:");
            string phoneNumberPattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
            string IPNumberPattern = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            string emailPattern = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
            proverka.Proverka(s,h);

        }
    }
}
