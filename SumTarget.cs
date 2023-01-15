using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    public class SumTarget
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int output = 0;
            int diff = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1, l = n - 1; j < l;)
                {
                    int sum = nums[i] + nums[j] + nums[l];
                    if (sum.Equals(target)) return sum;
                    if (sum < target) j++;
                    else l--;

                    int temp = Math.Abs(target - sum);
                    if (diff > temp)
                    {
                        diff = temp;
                        output = sum;
                    }
                }
            }
            return output;
        }
    }
}
