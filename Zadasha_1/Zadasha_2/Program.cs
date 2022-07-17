Console.WriteLine("Введите целое число ");
int num = int.Parse(Console.ReadLine());
if (num > 99)
{
    Console.WriteLine("Третья цифра = " + num % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

