using System;

public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');

        int n = int.Parse(s[0]);
        int m = int.Parse(s[1]);
        
        for(int j = 0; j < m; j++)
        {
            for(int i = 0; i < n; i++)
                Console.Write("*");
            Console.WriteLine();
        } 
    }
}