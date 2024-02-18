using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ravno : IntSpec2<string>
    {
        public void Validate(string str1, string str2)
        {
            string g = Regex.Replace(str1.Trim().ToUpper(), @"\s+", " "); ;
            string L = Regex.Replace(str2.Trim().ToUpper(), @"\s+", " "); ;
            if (g != L)
            {
                throw new ValidationException("Строки не равны");
            }
        }
    }
}
