using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Reversel : IntSpec2<string>
    {
        public void Validate(string str1, string str2)
        {
            string Reverse(string str)
            {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
            if (Reverse(str1) != (str2))
            {
                throw new ValidationException("Строки не перевертыши");
            }
        }
    }
}

