Console.WriteLine("Введи целое число от 10 до 99: ");
int a = Convert.ToInt32(Console.ReadLine());
int firstDigt = a / 10;
int secondDigt= a % 10;
if (firstDigt > secondDigt)
{
    Console.WriteLine(firstDigt);
}
else 
{
    Console.WriteLine(secondDigt);
}