using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCenter
{
    public class AlgorithmCenter191216
    {

        /// <summary>
        /// https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/
        /// 优化滑动窗口 [i,j]
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int res = 1;
            int tempRes = 1;
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            for (int i=0,j=0; j<s.Length;j++)
            {
                //判断在当前窗口中是否已经存在该字符
                if (keyValues.ContainsKey(s[j])&&keyValues[s[j]]>=i)
                {                                                                                                                                                                                                                                                                                                                                                                                                                                          
                    res = Math.Max(res, j-i);
                    i = keyValues[s[j]]+1; //移动窗口                                    
                }
                if(keyValues.ContainsKey(s[j]))//如果不在窗口并已经存在 删除
                     keyValues.Remove(s[j]);
                keyValues.Add(s[j],j);                
                tempRes=j-i+1;
            }

            return Math.Max(res, tempRes);
        }
    }
}
