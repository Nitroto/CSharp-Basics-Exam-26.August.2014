using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
class JumpingSums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] stringNumbers = Console.ReadLine().Split(' ');
        int j = int.Parse(Console.ReadLine());
        int[] nums = new int[stringNumbers.Length];
        List<int> sums = new List<int>();
        for (int i=0;i<stringNumbers.Length; i++)
        {
            nums[i] = int.Parse(stringNumbers[i]);
        }
        for (int index=0;index<nums.Length; index++)
        {

            int sum = nums[index];
            int nextIndex = (nums[index] + index)%nums.Length;
            for (int i = 0; i < j; i++)
            {
                sum += nums[nextIndex];
                nextIndex = (nums[nextIndex]+nextIndex)%nums.Length;
            }
            sums.Add(sum);
        }
        Console.WriteLine("max sum = {0}", sums.Max());
    }
}
