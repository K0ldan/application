using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProverkaStokiWTF : IntSpec2<string>
    {
        public void Validate(string str1, string str2)
        {
            if (str1 != str2)
            {
                throw new ValidationException("Строки не равны посимпольно");
            }
        }
    }
}
