//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/* int FindMaxNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 10;

    if(n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}

int number = new Random().Next(10,99);
Console.WriteLine("Current number is " + number + " max part is " + FindMaxNum(number));

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int DeleteTwo(int num)
{
    int n1 = (num / 100) * 10;
    int n2 = num % 10;
    return n1 + n2;
}
int number = new Random().Next(100,1000);

Console.WriteLine(number + " без второго числа будет " + DeleteTwo(number));

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деление.
void multy(int number1, int number2)
{
    if(number1 % number2 == 0) Console.Write("Первое число кратно второму!");
    else Console.WriteLine("Первое число некратно второму!");
}

Console.Write("Введите первое целое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

multy(n1,n2);
*/
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
void delenie(int num, int n1, int n2)
{
    if(num % n1 == 0 && num % n2 == 0) Console.Write("Число "+ num + " кратно " + n1 + " и " + n2);
    else Console.Write("Число "+ num + " некратно " + n1 + " и " + n2);
}
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
delenie(number, num1, num2);