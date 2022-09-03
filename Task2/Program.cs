double Promt(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double[] IntersectionPointCoord(double k1, double b1, double k2, double b2)
{
    double[] PointCoord = new double[2];
    PointCoord[1] = (k2*b1/k1 - b2)/(k2/k1 - 1);
    PointCoord[0] = (PointCoord[1] - b1)/k1;
    return PointCoord;
}

double k1 = Promt("Введите k1: ");
double b1 = Promt("Введите b1: ");
double k2 = Promt("Введите k2: ");
double b2 = Promt("Введите b2: ");

double[] Point = IntersectionPointCoord(k1, b1, k2, b2);

System.Console.WriteLine($"Точка пересечения прямых > ({Point[0]}; {Point[1]})");
