﻿Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23 ");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23 ");
}