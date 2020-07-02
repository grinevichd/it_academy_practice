using System;
using System.Transactions;

class Program
{

    static double CountСircle(double text)

    {
        return text * text * Math.PI;
    }
    static double CountSquare(double text1)
    {
        return text1 * text1;
    }
    static double CountTriangle(double text2, double text3)
    {
        return (text2 * text3) / 2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ввести радиус круга для вычисления площади");
        double text = Convert.ToDouble(Console.ReadLine());
        double resultCircle = CountСircle(text);
        Console.WriteLine("Площадь круга = " + resultCircle);
        Console.WriteLine("Введите сторону квадрата для вычисления площади");
        double text1 = Convert.ToDouble(Console.ReadLine());
        double resultSquare = CountSquare(text1);
        Console.WriteLine(resultSquare);
        Console.WriteLine("Введите основание треугольника: \n Введите высоту треугольника: ");
        double text2 = Convert.ToDouble(Console.ReadLine());
        double text3 = Convert.ToDouble(Console.ReadLine());
        double resultTriangle = CountTriangle(text2, text3);
        Console.WriteLine("Площадь треугольника = " + resultTriangle);


    }
}