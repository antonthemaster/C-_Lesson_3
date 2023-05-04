Console.WriteLine("Enter 6 var");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(
    Math.Pow((x2 - x1), 2) +
    Math.Pow((y2 - y1), 2) + 
    Math.Pow((z2 - z1), 2)
    );

Console.WriteLine(result);