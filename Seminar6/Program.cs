// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//A < B + C
/*Console.WriteLine("Введите три числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if((A+B)>C && (A+C)>B && (B+C)>A)
{
    Console.Write("Такой треугольник существует");
}
else
{
    Console.Write("Такой треугольник не существует");
}*/
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("Введите число, которое нужно перевести в двоичную систему: ");
int Num = Convert.ToInt32(Console.ReadLine());
int L = Convert.ToInt32(Math.Log(Num,2)+1);
int [] array = new int [L];
int D = Num; int chast = D/2; int ost = D%2;
int i = 0;
while (D >= 2)
{
    array[i] = ost;
    D = chast;
    chast = D/2;
    ost = D%2;
    i++;
}
array[i] = D;
int [] Num_Sist2 = new int [L];
for(i = 0; i<L; i++)
{
    Num_Sist2[i] = array[L - 1 - i];
}
Console.WriteLine("[{0}]", string.Join(" ", Num_Sist2));
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
