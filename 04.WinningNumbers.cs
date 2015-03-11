using System;
using System.Globalization;
using System.Threading;

class WinningNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string str = Console.ReadLine();
        int sum = 0;
        int count = 0;
        foreach (char letter in str)
        {
            if (letter>='a'&& letter<='z')
            {
                sum += letter - 'a' + 1;
            }
            else
            {
                sum += letter - 'A' + 1;
            }
        }
        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    int abc = int.Parse("" + a + b + c);
                    if ((a * b * c) == sum)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            for (int e = 1; e <= 9; e++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {
                                    int def = int.Parse("" + d + e + f);
                                    if ((d * e * f) == sum)
                                    {
                                        Console.WriteLine("{0}-{1}", abc, def);
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
