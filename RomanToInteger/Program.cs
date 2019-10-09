using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        private static Int32 RomanToInt (String s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return 0;
            }
            Dictionary<Char, Int32> romanValues = new Dictionary<char, int>();
            romanValues.Add('I', 1);
            romanValues.Add('V', 5);
            romanValues.Add('X', 10);
            romanValues.Add('L', 50);
            romanValues.Add('C', 100);
            romanValues.Add('D', 500);
            romanValues.Add('M', 1000);

            Int32 length = s.Length;
            romanValues.TryGetValue(s.Last(), out Int32 result);
            for (int i = length-2; i >= 0; i--)
            {
                romanValues.TryGetValue(s.ElementAt(i), out Int32 temp);
                //value to the right of temp in s which is a Roman Number String
                romanValues.TryGetValue(s.ElementAt(i+1), out Int32 temp1);
                if (temp >= temp1)
                {
                    result += temp;
                } else
                {
                    result -= temp;
                }
            }
            return result;
        }
    }
}
