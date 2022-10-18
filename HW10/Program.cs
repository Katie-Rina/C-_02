// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0;
if (Math.Abs(number) > 999 | Math.Abs(number) < 100)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    a = Math.Abs(number) % 100 /10;
    Console.WriteLine("Вторая цифра: " + a);
}

