using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CalculRast
    {
        public static int CalculRastchet(double value1, double value2)
        {
            try
            {
                try
                {
                    double x = value1;
                    double z= value2;
                    double p = (Math.Sqrt(x) - 6 / z);
                    Console.WriteLine("{0:0.000}", (Math.Sqrt(x) - 6 / z));
                    return (int)p;
                }
                catch (ValidationException e)
                {
                    Console.WriteLine($"Ошибка:{e.Message}");
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка ввода данных попробуйт");
                return 0;
            }
        }
    }
}
