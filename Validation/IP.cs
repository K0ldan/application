using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2.Validation
{
    public class IP : IntSpec2<string>
    {
        public void Validate(string str1, string str2)
        {
            if (!IsEmailOrPhoneNumberOrIpAddress(str1) || !IsEmailOrPhoneNumberOrIpAddress(str2))
            {
                throw new ValidationException("Одна из строк не является IP адресом.");
            }
            bool IsEmailOrPhoneNumberOrIpAddress(string input)
            {
                // Регулярные выражения для проверки email, телефонных номеров и IP-адресов
                string IPNumberPattern = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
                return Regex.IsMatch(input, IPNumberPattern);
            }
        }
    }
}
