﻿using System;

Console.Write("Ordet ? ");
string ord = Console.ReadLine();

Console.Write("Antal upprepningar ? ");
int antal = int.Parse(Console.ReadLine());
    
Console.WriteLine($"Svar: {String.Concat(Enumerable.Repeat(ord, antal))}");