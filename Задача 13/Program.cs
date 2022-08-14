Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = num;
if ((num < 1000) && (num > 99)) Console.WriteLine($"Третья цифра числа {numbers}: {num % 10}");
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else while (num > 1000)
    {
        num = num / 10;
    }