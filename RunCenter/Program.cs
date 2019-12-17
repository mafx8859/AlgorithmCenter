using AlgorithmCenter;
using DataStructCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunCenter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LengthOfLongestSubstringTest();
            Console.ReadKey();
        }

        public static void TwoSumTest()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            var res=AlgorithmCenter.AlgorithmCenter191212.TwoSum(nums,9);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void TwoSumV2Test()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            var res = AlgorithmCenter.AlgorithmCenter191212.TwoSumV2(nums, 9);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void AddTwoNumbersTest()
        {
            ListNode l1 = new ListNode(2);
            l1.Add(4).Add(3);

            ListNode l2 = new ListNode(5);
            l2.Add(6);

            var res=AlgorithmCenter.AlgorithmCenter191213.AddTwoNumbers(l1,l2);

            while (res != null)
            {
                Console.Write(res.val);
                res = res.next;
            }

        }

        public static void LengthOfLongestSubstringTest()
        {
            int res=AlgorithmCenter191216.LengthOfLongestSubstring("a");
            Console.Write(res);
        }
    }
}
