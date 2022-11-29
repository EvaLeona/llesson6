
double[] InputParam() 
{
    double[] res = new double[4];
 
    int n = 1;
    for (int i = 0; i < 4; i += 2)
    {
        Console.WriteLine($"{n}-е уравнение y = k{n} * x + b{n}");
        Console.Write($" k{n} = "); res[i] = double.Parse(Console.ReadLine());
        Console.Write($" b{n} = "); res[i + 1] = double.Parse(Console.ReadLine());
        n++;
    }
    return res;
}

double[]? PointsIntersectionOfStraightLines(double[] arg)
{
    

    if (arg[1] == arg[3] && arg[0] == arg[2]) 
    {
        Console.WriteLine("Прямые совпадают. Точек пересечения бесконечное множество."); 
        return null;
    }
    if (arg[0] == arg[2])
    {
        Console.WriteLine("Прямые параллельны. Точек пересечения нет");
        return null;
    }


    double[] res = new double[2]; 
    res[0] = (arg[3] - arg[1]) / (arg[0] - arg[2]);  
    res[1] = arg[0] * res[0] + arg[1];
    return res;
}


double[] parametryStraightLine = InputParam();
double[] point = PointsIntersectionOfStraightLines(parametryStraightLine);
if (point is null) return;
Console.WriteLine($"Точка пересечения ( {point[0]:F1} , {point[1]:F1} )");

