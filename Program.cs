// https://paiza.jp/challenges/480/show

using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var N = int.Parse(line[0]);
        var X = int.Parse(line[1]);
        var Y = int.Parse(line[2]);
        for (int i = 1; i < N+1; i++)
        {
            if(i % X == 0&& i % Y == 0)
            {
                Console.WriteLine("AB");
            }
            else if (i % X == 0)
            {
                Console.WriteLine("A");
            }
            else if (i % Y == 0)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

    }
}