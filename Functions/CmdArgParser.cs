using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Functions
{
    public class CmdArgsParser
    {
        public static IDictionary<string, string> Parse(string[] args)
        {
            if (args == null || args.Length == 0) return null;

            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int iArg = 0; iArg < args.Length; iArg++)
            {
                string arg = args[iArg];
                if (arg.StartsWith("-"))
                {
                    string paraName = arg.TrimStart('-');
                    if (iArg + 1 >= args.Length)
                    {
                        throw new InvalidOperationException(string.Format("Incorrect args. {0} must have value", args));
                    }
                    if (dic.Keys.Contains(paraName))
                    {
                        throw new InvalidOperationException(string.Format("Incorrect args. {0} must specify once", paraName));
                    }
                    string paraValue = args[++iArg];
                    dic.Add(paraName, paraValue);
                }
            }
            return dic;
        }
    }
}
