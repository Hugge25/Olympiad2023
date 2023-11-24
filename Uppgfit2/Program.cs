using System;


Console.Write("N ? ");
int N = int.Parse(Console.ReadLine());

int a = 1;
int b = 2;
int c = 3;
int Svar = 0;

while(true)
{
    if((a * b * c) < N)
    {
        Svar += 1;

        a += 1;
        b += 1;
        c += 1;
    }
    else
        break;
    
}
Console.WriteLine($"\nSvar: {Svar}");



