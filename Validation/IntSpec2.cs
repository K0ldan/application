using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IntSpec2<T>
    {
        void Validate(T value,T value2);
    }
}
