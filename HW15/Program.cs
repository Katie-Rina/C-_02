// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();
Console.Write("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 | day > 7)
{
    Console.WriteLine("Это не номер дня недели");
}
else 
{
    if (day > 5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}
