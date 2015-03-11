using System;
using System.Globalization;
using System.Threading;

class XBits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[] nums = new int[8];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        for (int i=0; i<nums.Length-2;i++)
        {
            for (int bit = 31; bit >= 2; bit--)
            {
                int firstNumBit1 = nums[i]>>bit & 1;
                int firstNumBit2 = nums[i]>>(bit - 1) & 1;
                int firstNumBit3 = nums[i] >> (bit - 2) & 1;
                if (firstNumBit1 == 1&&firstNumBit2==0&&firstNumBit3==1)
                {
                    int secondNumBit1 = nums[i+1] >> bit & 1;
                    int secondNumBit2 = nums[i+1] >> (bit - 1) & 1;
                    int secondNumBit3 = nums[i+1] >> (bit - 2) & 1;
                    if (secondNumBit1 == 0 && secondNumBit2 == 1 && secondNumBit3 == 0)
                    {
                        int thirdNumBit1 = nums[i+2] >> bit & 1;
                        int thirdNumBit2 = nums[i+2] >> (bit - 1) & 1;
                        int thirdNumBit3 = nums[i+2] >> (bit - 2) & 1;
                        if (thirdNumBit1 == 1 && thirdNumBit2 == 0 && thirdNumBit3 == 1)
                        {
                            counter++;
                        }
                    }
                }
            }
        }
        Console.WriteLine("{0}", counter);
    }
}
