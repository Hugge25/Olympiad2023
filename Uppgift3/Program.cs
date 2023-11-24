using System;

Console.Write("n ? ");
int n = int.Parse(Console.ReadLine());

Console.Write("m ? ");
int m = int.Parse(Console.ReadLine());

string[] rader = new string[n];

char[] c = new char[rader.Length];

string Svar = "";



for(int i = 0; i < n; i++)
{
    Console.Write($"Rad {i+1} ? ");
    rader[i] = Console.ReadLine();
    c = rader[i].ToCharArray();

        for(int j = 0; j < rader[i].Length; j++)
        {
            if(c[j] != '.')
            {
                Svar += c[j];
            }
        }
}

Console.WriteLine($"\nSvar: {Svar}");
