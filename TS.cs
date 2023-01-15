using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    class TS
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] index = new int[2] { 0, 0 };
            var length = 0;
            foreach (int k in nums)
            {
                length = length + 1;
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == target)
                    {
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }
    }
}
