// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// using System;

// public class Program
// {
//     public static string Range(int m, int n)
//     {
//         if (m >= n)
//             return "";
//         else
//             return m + " " + Range(m + 1, n);
//     }

//     public static void Main()
//     {
//         Console.Write("Введите M: ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите N: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(Range(m, n+1));
//     }
// }

// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// using System;

// public class Program
// {
//     public static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }

//     public static void Main()
//     {
//         Console.Write("Введите m: ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите n: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(Ackermann(m, n));
//     }
// }


// // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы

// using System;

// public class Program
// {
//     public static string ReverseArray(int[] array)
//     {
//         if (array.Length == 0)
//             return "";
//         else
//             return array[array.Length - 1] + ", " + ReverseArray(array.Take(array.Length - 1).ToArray());
//     }

//     public static void Main()
//     {
//         Console.Write("Введите элементы массива, разделенные запятыми: ");
//         string input = Console.ReadLine();
//         string[] elements = input.Split(',');
//         int[] array = Array.ConvertAll(elements, int.Parse);
//         Console.WriteLine(ReverseArray(array));
//     }
// }

