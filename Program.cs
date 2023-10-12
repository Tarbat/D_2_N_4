using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        Random rnd = new Random();
        int SumK = 0;

        Console.Write("n - Number of rows = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("m - Number of seats in rows = ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] Places = new int[n, m];

        for (int i = 0; i != n; i++)
        {
            for (int j = 0; j != m; j++)
            {
                Places[i, j] = rnd.Next(0, 2);
                Console.Write(Places[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("k - Number of tickets to be purchased = ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i != n; i++)
        {
            for (int j = 0; j != m; j++)
            {
                if (Places[i, j] == 0) { SumK++; }
                int Cur_i = i + 1;
                if (SumK == k) { Console.Write("A row with enough seats = " + Cur_i); return; }
            }
            SumK = 0;
        }

        Console.Write("There's no matching row " + 0);
        return;
    }
}