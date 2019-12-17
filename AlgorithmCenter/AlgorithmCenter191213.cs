using DataStructCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCenter
{
    public class AlgorithmCenter191213
    {
        /// <summary>
        /// https://leetcode-cn.com/problems/add-two-numbers/
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            
            ListNode head = new ListNode(0);
            ListNode currentNode = head;

            while (l1 != null || l2 != null)
            {
                int temp = (l1==null?0:l1.val) + (l2 == null ? 0 : l2.val) + currentNode.val;
                int gw = temp % 10;
                currentNode.val = gw;

                ListNode nextNode=null;
                if (l1?.next!=null||l2?.next!=null|| temp / 10>0)
                    nextNode = new ListNode(temp/10);

                currentNode.next = nextNode;
                currentNode = nextNode;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return head;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/
        /// 滑动窗口
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            Dictionary<char, int> keyValues = null;
            int res=1;
            int resTemp = 1;
            for (int i = 0; i < s.Length; i++)
            {
                keyValues = new Dictionary<char, int>();
                char startChar = s[i];
                resTemp = 1;
                keyValues.Add(startChar,i);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (!keyValues.ContainsKey(s[j]))
                    {
                        resTemp++;
                        keyValues.Add(s[j], j);
                    }
                    else
                    {
                       // res = resTemp > res ? resTemp : res;
                        i = keyValues[s[j]];
                        break;
                    }
                }
                res = resTemp > res ? resTemp : res;
            }
            return resTemp > res ? resTemp : res;
        }
    }
}
