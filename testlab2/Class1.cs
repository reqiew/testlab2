using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testlab2
{
    public class Class1
    {
        public bool IsPalindrome(int number)
        {
            string strNumber = number.ToString();
            char[] charArray = strNumber.ToCharArray();
            Array.Reverse(charArray);
            string reversedStrNumber = new string(charArray);

            return strNumber.Equals(reversedStrNumber, StringComparison.OrdinalIgnoreCase);
        }
    }
}
