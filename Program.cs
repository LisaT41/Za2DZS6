//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CrossPoint(double b1, double k1, double b2, double k2)
{ 
   
    if (k1 !=k2)
    {
        double  x = Math.Round((b2 - b1)/(k1 - k2),2); 
        double y = Math.Round(k1*x + b1,2);
        Console.WriteLine($"Координаты точки пересечения = {x},{y}");
    } 
         
     else if(k1 == k2 && b1 !=b2) 
        Console.WriteLine("Прямые параллельны");
     else if(k1 == k2 && b1 == b2) 
        Console.WriteLine("Прямые совпадают");
}

Console.WriteLine("Input b1 = " );
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(b1, k1, b2, k2);


