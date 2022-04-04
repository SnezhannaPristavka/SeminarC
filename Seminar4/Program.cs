int Sum(int Num)
{
    int result = 0;
    for (int i = 1; i <= Num; i++)
    {
        result += i;
    }
    return result;
}

int Col(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int Um(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(0, 2);
        Console.Write(massiv[i]);
    }
}

// 1) Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*Console.Write("Enter interge ");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write("Sum: "+ Sum(A));*/
// 2) Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*Console.Write("Enter interge ");
int number = Convert.ToInt32 (Console.ReadLine());
Console.Write(Col(number));*/
// 3) Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*Console.Write("Enter interge ");
int Num = Convert.ToInt32 (Console.ReadLine());
Console.Write(Um(Num));*/
// 4) Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] array = new int[8];
FillArray (array);