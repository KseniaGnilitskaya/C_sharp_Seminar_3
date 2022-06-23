Console.WriteLine("Enter coordinate X for the first point: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Y for the first point: ");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinate X for the second point: ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinate Y for the second point: ");
int Y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2));
Console.WriteLine(result);

//Console.WriteLine("Введите координату Х первой точки");
//double x1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите координату Y первой точки");
//double y1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите координату Х второй точки");
//double x2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите координату Y второй точки");
//double y2 = Convert.ToDouble(Console.ReadLine());
//
//double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//Console.WriteLine(result);