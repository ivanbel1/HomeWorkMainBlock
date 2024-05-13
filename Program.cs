using System;
using System.Linq.Expressions;
using System.Net.Sockets;
using Microsoft.VisualBasic;
// See https://aka.ms/new-console-template for more information




string[] array2 = ["Вася", "Олег", "8", "12", "Дмитрий"];
Console.WriteLine("Ваш первоначальный массив : " + string.Join(",", array2));



for (int i = 0; i < array2.Length; i++)
{
    if (array2[i].Length > 3)
    {
        Array.Resize(ref array2, 3);
    }
}

Console.WriteLine("Результат : " + string.Join(",", array2));
