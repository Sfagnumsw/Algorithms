using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    class ZigZagString
    {
        public static string ConvertString(string str, int countRow)
        {
            string[] storeString = new string[countRow];
            int i = 0;
            while (i < str.Length)
            {
                for (int vertical = 0; vertical < countRow && i < str.Length; vertical++)
                {
                    storeString[vertical] = storeString[vertical] + str[i++];
                }
                for (int intermediate = countRow - 2; intermediate >= 1 && i < str.Length; intermediate--)
                {
                    storeString[intermediate] = storeString[intermediate] + str[i++];
                }
            }
            for (int j = 1; j < storeString.Length; j++)
            {
                storeString[0] = storeString[0] + storeString[j];
            }
            return storeString[0];
        }
    }
}
