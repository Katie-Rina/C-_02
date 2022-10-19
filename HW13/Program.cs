// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// if (Math.Abs(number) < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     a = Math.Abs(number);
//     string num = a.ToString();
//     Console.WriteLine("Третья цифра: " + num[2]);
// }


Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();
char[] minus = {'-','0'};
string absnumber = number.TrimStart(minus);
if (absnumber.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра: " + absnumber[2]);
}