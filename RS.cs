using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    class RS
    {
        public class Opp
        {
            public int Reverse(int x)
            {
                int result = 0;
                while (x != 0)
                {
                    int digit = x % 10;
                    try
                    {
                        result = checked(result * 10 + digit);
                    }
                    catch (OverflowException)
                    {
                        return 0;
                    }
                    x = x / 10;
                }
                return result;
            }
        }
    }
}
