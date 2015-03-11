using System;
using System.Globalization;
using System.Threading;

class Star
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int spaces = 0;
        int midSpaces = -1;
        Console.Write(new string('.', n));
        Console.Write('*');
        Console.Write(new string('.', n));
        Console.WriteLine();
        for (int i = 0; i < n / 2-1; i++)
        {
            spaces++;
            midSpaces += 2;
            Console.Write(new string('.', n-spaces));
            Console.Write('*');
            Console.Write(new string('.', midSpaces));
            Console.Write('*');
            Console.Write(new string('.', n-spaces));
            Console.WriteLine();
        }
        midSpaces += 2;
        Console.Write(new string('*', n - spaces));
        Console.Write(new string('.', midSpaces));
        Console.Write(new string('*', n - spaces));
        Console.WriteLine();
        spaces = 0;
        midSpaces = -1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            spaces++;
            midSpaces += 2;
            Console.Write(new string('.', spaces));
            Console.Write('*');
            Console.Write(new string('.', 2*n-2*spaces-1));
            Console.Write('*');
            Console.Write(new string('.', spaces));
            Console.WriteLine();
        }
        spaces++;
        midSpaces = -1;
        Console.Write(new string('.', spaces));
        Console.Write('*');
        Console.Write(new string('.',  n / 2 - 1));
        Console.Write('*');
        Console.Write(new string('.', n / 2 - 1));
        Console.Write('*');
        Console.Write(new string('.', spaces));
        Console.WriteLine();
        for (int i = 0; i < n / 2 - 1; i++)
        {
            spaces--;
            midSpaces += 2;
            Console.Write(new string('.', spaces));
            Console.Write('*');
            Console.Write(new string('.', n / 2 - 1));
            Console.Write('*');
            Console.Write(new string('.', midSpaces));
            Console.Write('*');
            Console.Write(new string('.', n / 2 - 1));
            Console.Write('*');
            Console.Write(new string('.', spaces));
            Console.WriteLine();
        }
        midSpaces += 2;
        Console.Write(new string('*', n/2+1));
        Console.Write(new string('.', midSpaces));
        Console.Write(new string('*', n / 2 + 1));
        Console.WriteLine();
    }
}
