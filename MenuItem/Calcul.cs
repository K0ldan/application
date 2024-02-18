using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    public class Calcul : MenuItemCore
    {
        private lessZERO less;
        private NOZERO nOZERO;
        public override string Title { get { return "Calculator"; } }
        public override void Execute()
        {
            Console.WriteLine("sqrt(X)-6/Z");
            less = new lessZERO();
            nOZERO = new NOZERO();
            double x = IOUtils.SafeReadInteger("x","Введите X:");
            double z = IOUtils.SafeReadInteger("z","Введите Z:");
            try
            {
                nOZERO.Validate(z);

                less.Validate(x);
                
                CalculRast.CalculRastchet(x, z);
                
            }
            catch (ValidationException e) 
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}