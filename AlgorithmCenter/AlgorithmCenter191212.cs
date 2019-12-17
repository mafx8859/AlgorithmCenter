using DataStructCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCenter
{
    public class AlgorithmCenter191212
    {
        /// <summary>
        /// https://leetcode-cn.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {

            int[] res = new int[2];           
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int last = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == last)
                    {
                        flag = true;
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }

            return flag?res:new int[0];

        }


        /// <summary>
        /// https://leetcode-cn.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumV2(int[] nums, int target)
        {

            int[] res = new int[2];
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (keyValues.ContainsKey(temp))
                {
                    res[0] = i;
                    res[1] = keyValues[temp];
                    return res;
                }
                keyValues[nums[i]] = i;
            }

            return new int[0];
        }
    }
}
