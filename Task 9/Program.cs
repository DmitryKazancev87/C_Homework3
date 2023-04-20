// 9. Программа принимающая на входе координаты двух точек и находящая расстояние между ними
// в 3D пространстве.
// Вводим координату первой точки:
Console.WriteLine("Введите координату X первой точки :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки :");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки :");
int z1 = Convert.ToInt32(Console.ReadLine());
// Вводим координату второй точки:
Console.WriteLine("Введите координату X второй точки :");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки :");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки :");
int z2 = int.Parse(Console.ReadLine());
// Формула нахождения расстояния между двумя точками в трехмерном пространстве:
// d12=Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1)), где Sqrt - квадратный корень.

int A = x2-x1;
int B = y2-y1;
int C = z2-z1;

double Length = Math.Sqrt (A*A+B*B+C*C);
System.Console.WriteLine($"{Length} расстояние между точками в трехмерном пространстве"); 
