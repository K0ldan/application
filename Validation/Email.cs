using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2.Validation
{
    public class Email : IntSpec2<string>
    {
        public void Validate(string str1, string str2)
        {
            if (!IsEmailOrPhoneNumberOrIpAddress(str1) || !IsEmailOrPhoneNumberOrIpAddress(str2))
            {
                throw new ValidationException("Одна из строк не является email'ом.");
            }
            bool IsEmailOrPhoneNumberOrIpAddress(string input)
            {
                // Регулярные выражения для проверки email, телефонных номеров и IP-адресов
                string emailPattern = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
                return Regex.IsMatch(input, emailPattern);
            }
        }
    }
}
