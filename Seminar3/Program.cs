int GetQuart(double xPoint, double yPoint)
{
    if(xPoint > 0 && yPoint > 0) return 1;
    if(xPoint < 0 && yPoint > 0) return 2;
    if(xPoint < 0 && yPoint < 0) return 3;
    if(xPoint > 0 && yPoint < 0) return 4;
    if(xPoint == 0 || yPoint == 0) return 0;
}

double x,y;
Console.Write ("Input x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input y: ");
y = Convert.ToDouble(Console.ReadLine());

