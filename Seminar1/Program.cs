/*
Console.Write("Введите целое число ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value*value;
Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);
*/

/*
Console.Write("Введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_value2 = value2*value2;
if (kvadrat_value2 == value1)
{
    Console.WriteLine("Да,является");
}
else
{
    Console.WriteLine("Нет, не является");
}


Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("Понедельник");
    }
     if(number == 2)
    {
        Console.WriteLine("Вторник");
    }
}
else
{
    Console.WriteLine("Не существует");
}
*/
Console.Write("Введите натуральное число ");
int N = Convert.ToInt32(Console.ReadLine());
int neg_N = N*(-1);
while(neg_N<=N)
{
    Console.WriteLine(neg_N);
    neg_N++;
}