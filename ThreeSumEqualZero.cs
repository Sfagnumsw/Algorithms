using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkLetsGo
{
    public class ThreeSumEqualZero
    {
        public IList<IList<int>> ThreeSum(int[] nums) //принимает массив интов, надо найти все уникальные триплеты, которые в сумме дают 0
        {
            Array.Sort(nums);
            HashSet<int[]> result = new HashSet<int[]>();
            int n = nums.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1, k = n - 1; j < k;)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    var triplet = new int[] { nums[i], nums[j], nums[k] };
                    if (sum == 0 && !result.Contains(triplet)) // проверка на наличие триплета в резалте не работает
                    {
                        result.Add(new int[] { nums[i], nums[j], nums[k] });
                    }
                    if (sum < 0) j++;
                    else k--;
                }
            }
            return result.ToArray();
        }
    }
}
