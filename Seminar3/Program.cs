﻿/* 
Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetQuart (double xPoint, double yPoint)
{
    if(xPoint > 0 && yPoint > 0) return 1;
    if(xPoint < 0 && yPoint > 0) return 2;
    if(xPoint < 0 && yPoint < 0) return 3;
    if(xPoint > 0 && yPoint < 0) return 4;
    return 0;
}

double x,y;
int quartNum;
Console.Write ("Input x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x,y);
if (quartNum == 0) Console.WriteLine ("Нельзя однозначно определить четверть");
else Console.WriteLine("Данная точка находится в " + quartNum + " четверти");
*/

// Написать программу, которая принимает на вход номер четверти ивыводит на экран диапазон координат, доступных в этой четверти

/* void GetQuart (int arg)
{

}
*/
// Задача 3 Найти расстояние между двумя точками.

double GetDistance(double x1, double y1, double x2, double y2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;

    return Math.Sqrt(Math.Pow(xDistance ,2)+(Math.Pow(yDistance ,2)));
}

double xA, yA, xB, yB;
// double distance;

Console.Write ("Input x of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input x of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, xB, yB));