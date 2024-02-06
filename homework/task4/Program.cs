Console.WriteLine("Введите натурильное число N:");
int n=Convert.ToInt32(Console.ReadLine());
if (n<10)
{
    Console.Write(n);
}
else
{
    while(n>0)
    {
        Console.Write($"{n%10} ");
        n=n/10;
    }
}