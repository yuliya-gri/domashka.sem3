﻿double input( string x, string y)
{
    Console.WriteLine($"Введите {x} координату точки {y}");
    return Convert.ToDouble(Console.ReadLine());
}

try
{
    double xA = input("x", "A");
    double yA = input("y", "A");
    double zA = input("z", "A");
    double xB = input("x", "B");
    double yB = input("y", "B");
    double zB = input("z", "B");
   
    double result = Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
    Console.WriteLine(("Расстояние между точками:") + Math.Round(result, 2));

}
catch 
{
    Console.WriteLine("ошибка выполнения");
}
