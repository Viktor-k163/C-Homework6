// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите количество чисел: ");
int elememtsArray = int.Parse(Console.ReadLine()!);
int [] arr = new int [elememtsArray];

for (int i = 0; i < arr.Length; i++)
{
  Console.Write($"Введите элемент маасива {i}: ");
  arr[i] = int.Parse(Console.ReadLine()!);
}
int res = FindNumber(arr);
Console.WriteLine($"[{String.Join(",", arr)}]"!);
Console.WriteLine($"Из всех введенных пользователем чисел, только {res} больше 0");

int FindNumber(int[] arr)//метод проверки числа больше 0 
{
  int count = 0;
  for(int i = 0; i < arr.Length; i++)
  if (arr[i] > 0)
  {
    count ++;
  }
  return count;
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,заданных уравнениями
// y = k1 * x + b1,
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, 
// b2 = 4, k2 = 9 
// -> (-0,5; -0,5)
// 5 * -1,25 + 2 = -4,25
// 9 * -1,25 + 4 = -7,25

// Console.WriteLine("Введите число b1: ");
// int b1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число k1: ");
// int k1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число b2: ");
// int b2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число k2: ");
// int k2 = int.Parse(Console.ReadLine()!);
// CrossPoint(k1,b1,k2,b2);

// void CrossPoint(double k1, double b1, double k2, double b2)
// {
//   double x = (b1-b2)/(k2-k1);
//   double y = (k2*b1-k1*b2)/(k2-k1);
//   if(k1 != k2)
//   Console.Write($"Координаты точки пересечения двух прямых равна (x = {x}; y = {y})");
//   else
//   Console.Write("Прямые не пересекаются!");
// }