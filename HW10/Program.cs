// Console.Clear();
// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// if (Math.Abs(number) > 999 | Math.Abs(number) < 100)
// {
//     Console.WriteLine("Число не трёхзначное");
// }
// else
// {
//     a = Math.Abs(number) % 100 /10;
//     Console.WriteLine("Вторая цифра: " + a);
// }


Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();
char[] minus = {'-','0'};
string absnumber = number.TrimStart(minus);
if (absnumber.Length != 3)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    Console.WriteLine("Вторая цифра: " + absnumber[1]);
}
