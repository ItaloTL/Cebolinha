﻿//string Cebolinha
Console.Clear();
string fraseDigitada, trocandoRPorL;
Console.WriteLine("Escleva algo pala mim");
fraseDigitada = Console.ReadLine()!;
trocandoRPorL = fraseDigitada
    .Replace("r","l")
    .Replace("l","r");
Console.WriteLine(trocandoRPorL);