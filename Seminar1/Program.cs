/*
Console.Write("Введите целое число ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value*value;
Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);
*/

Console.Write("Введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value1*value1;
if (kvadrat_value == value2)
{
    Console.WriteLine("Да,является");
}
else
{
    Console.WriteLine("Нет, не является");
}