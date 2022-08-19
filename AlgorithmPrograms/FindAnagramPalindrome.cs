using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class FindAnagramPalindrome
    {
        public static void findPalindrome(int num)
        {
            int originalNum = num; // we are storing the num value in originalnum so we can compare it afterwards
            int palin = 0, ans;
            while (num > 0) //in this loop when the number is greater the 0 then it will go inside the loop
            {
                ans = num % 10; // In this, remainder is calculated
                palin = palin * 10 + ans; //from this formula we will get one by one value from end and store in palin
                num /= 10; //in this, quotient is calculated
            }
            if (originalNum == palin) // if originalNum and palin value is same then it will print number is palindrome
            {
                Console.WriteLine(originalNum+" is Palindrome");
            }
        }
        public static void findAnagram(int[] arr, int num)
        {
            int[] num1 = num.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int[] arr1 = new int[arr.Length];
            Array.Sort(num1);
            int n=0;
            for (int i = 0; i < num1.Length; i++)
            {
                n += num1[i] * Convert.ToInt32(Math.Pow(10, num1.Length - i - 1));
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if(n == arr[i])
                {
                    if (!arr1.Contains(n))
                    {
                        arr1[i] = num;
                    }
                    break;
                }
            }
            for(int j = 0; j < arr1.Length; j++)
                Console.WriteLine(arr1[j]);
        }
    }
}
