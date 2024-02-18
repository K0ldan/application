using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class lessZERO : IntSpec<double>
    {
        public void Validate(double value)
        {
            if (value < 0)
            {
                throw new ValidationException(string.Format("Value {0} is less.", value));
            }
        }
    }
}
