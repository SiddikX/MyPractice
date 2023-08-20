using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static string ToShortString(this string originalString, int length)
        {
            if(length > originalString.Length)
                return originalString;
            else
                return originalString.Substring(0, length);
        }
    }
}
