/*********************************
 *
 * 文件名(File Name)      Practise.cs
 * 
 * 功能描述(Description)： CodeWar第八级练习题目
 * 
 * 作者(Atuhor)           wangxiaodang
 * 
 * 创建(Create Time)      2020/01/4
 * 
 * 修改记录(Revision History)
 * 
 *      R1:
 *         修改作者：
 *         修改日期：
 *         修改理由：
 * *******************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsBase
{
    public class Practise_1
    {
        /// <summary>
        /// 1，Complete the solution so that it reverses the string value passed into it.
        /// 1，完成解决方案，使其反转传入的字符串值。
        /// </summary>
        /// <returns></returns>
        public static string First(string target)
        {
            char[] array = target.ToArray();        //这里引用了linq

            string result = string.Empty;
            for (int i = array.Length-1; i >-1 ; i--)
            {
                result += array[i].ToString();
            }

            return result;
        }

        /// <summary>
        /// Count the number of Duplicates
        /// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
        /// </summary>
        /// <returns></returns>
        public static int DuplicateCount(string str)
        {
            //使用正则表达式，将指定的字符串找出来
            //问题遗留：不会Regex API函数
            return -1;
        }

        /// <summary>
        /// 1,In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
        /// 1,在这个简单的作业中，给你一个数字，必须使它为负数。但也许数字已经是负数了?
        /// </summary>
        /// <returns></returns>
        public static int MakeNegative(int number)
        {
            if (number > 0) return -number;
            return number;
        }

        /// <summary>
        /// 1,We need a function that can transform a number into a string.
        /// 1,我们需要一个能把数字转换成字符串的函数。
        /// </summary>
        /// <returns></returns>
        public static string NumberToString(int number)
        {
            return number.ToString();
        }


        /*
         * Bouncing Balls
         * 
         * A child is playing with a ball on the nth floor of a tall building. The height of this floor, h, is known.
           He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).
           His mother looks out of a window 1.5 meters from the ground.
           How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?

           Three conditions must be met for a valid experiment:
           Float parameter "h" in meters must be greater than 0
           Float parameter "bounce" must be greater than 0 and less than 1
           Float parameter "window" must be less than h.
           If all three conditions above are fulfilled, return a positive integer, otherwise return -1.

           Note:
           The ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.
         */
    }
}
