using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    class Roman
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanValue = new Dictionary<char, int>()
                {
                    {'I', 1 },
                    {'V', 5 },
                    {'X', 10 },
                    {'L', 50 },
                    {'C', 100 },
                    {'D', 500 },
                    {'M', 1000 }
                };
            int[] integerValue = new int[s.Length];
            int k = 0;
            var keys = romanValue.Keys;
            foreach (var i in s)
            {
                foreach (var j in keys)
                {
                    if (i == j)
                    {
                        integerValue[k] = romanValue[j];
                        k++;
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < integerValue.Length; i++)
            {
                if (i + 1 != integerValue.Length && integerValue[i + 1] > integerValue[i])
                {
                    result = result + (integerValue[i + 1] - integerValue[i]);
                    i++;
                }
                else
                {
                    result = result + integerValue[i];
                }
            }
            return result;
        }
    }
}
