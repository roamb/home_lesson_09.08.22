Console.WriteLine("Введите день недели:");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 && number <= 5)
{
    Console.WriteLine("Рабочий");
}
else
{
    Console.WriteLine("Выходной");
}