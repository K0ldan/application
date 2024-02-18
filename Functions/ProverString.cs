using ConsoleApp2.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProverString
    {
        private ProverkaStokiWTF ravnosimvol;
        private Ravno ravn;
        private Reversel ravnsel;
        private Email email;
        private IP iptst;
        private telephone telephone;
        public void Proverka(string s,string h)
        {
            ravnosimvol = new ProverkaStokiWTF();
            ravn = new Ravno();
            ravnsel = new Reversel();
            email = new Email();
            IP iptst = new IP();
            telephone = new telephone();
            string x = s;
            string y = h;
            string phoneNumberPattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
            string IPNumberPattern = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            string emailPattern = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
            try
            {
                ravnosimvol.Validate(x, y);
                Console.WriteLine("1)Строки совпадают посимвольно");
            }
            catch(ValidationException ex)
            {
                Console.WriteLine($"Ошибка:{ex.Message}");
            }
            try
            {

                ravn.Validate(x, y);
                Console.WriteLine("2)Строки совпадают");
            }
            catch (ValidationException ex) 
            {
                Console.WriteLine($"Ошибка:{ex.Message}");
            }
            try
            {
                ravnsel.Validate(x, y);
                Console.WriteLine("3)Являются перевёртышем к другой");
            }
            catch (ValidationException m)
            {
                Console.WriteLine($"Ошибка:{m.Message}");
            }
            try
            {
                bool isPhoneNumber = Regex.IsMatch(s, phoneNumberPattern);
                Console.WriteLine($"Строка'{x}' являеться номером телефона {isPhoneNumber}");
                
                bool isPhoneNumber2 = Regex.IsMatch(h, phoneNumberPattern);
                Console.WriteLine($"Строка '{y}' является номером телефона {isPhoneNumber2}");
                telephone.Validate(x, y); 
            }
            catch(ValidationException g)
            {
                Console.WriteLine($"Ошибка:{g.Message}");
            }
            try
            {
                bool isIPNumber1 = Regex.IsMatch(s, IPNumberPattern);
                Console.WriteLine($"Строка '{x}' является ip адресом {isIPNumber1}");

                bool isIPNumber2 = Regex.IsMatch(h, IPNumberPattern);
                Console.WriteLine($"Строка '{y}' является ip адресом {isIPNumber2}");
                iptst.Validate(x, y);
            }
            catch(ValidationException se)
            {
                Console.WriteLine($"Ошибка:{se.Message}");
            }
            try
            {
                bool isemailNumber1 = Regex.IsMatch(s, emailPattern);
                Console.WriteLine($"Строка '{x}' является email адресом {isemailNumber1}");

                bool isemailNumber2 = Regex.IsMatch(h, emailPattern);
                Console.WriteLine($"Строка '{y}' является email адресом {isemailNumber2}");
                email.Validate(x, y);
            }
            catch(ValidationException de)
            {
                Console.WriteLine($"Ошибка:{de.Message}");
            }


















            string Reverse(string str)
            {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
        }
    }

}
           
