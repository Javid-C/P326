using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed__static
{
    static class Extension
    {
        public static string MakeCapital(this string asdasd,int a, bool b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(asdasd[0]));
            sb.Append(asdasd.Substring(1).ToLower());
            return sb.ToString();
        }
        public static int Add(this int num, int addedNum)
        {
            return num + addedNum;
        }
    }
}
