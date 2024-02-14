using System;

namespace Task1
{
    class Program
    {
        // Creating functions
        public static void input(int[] a)
        {
            if (a == null || a.Length == 0)
                return;
            Random R = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = R.Next(-30, 30);
        }
        public static void output(int[] a)
        {
            if (a == null || a.Length == 0)
                return;
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i],15}");
        }
        public static void reverse(int[] a)
        {
            if (a == null || a.Length == 0)
                return;
            for (int i = 0; i < a.Length / 2; i++)
            {
                var temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
        }
        public static void sort(int[] a)
        {
            if (a == null || a.Length == 0)
                return;
            // Sort implementation
            Array.Sort(a);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            ////Вывод на консол таблитца
            //for (int i = 0; i < 256; i++) 
            //{
            //    if (i % 7 == 0) Console.WriteLine();
            //    Console.Write($ "{(char)i,10} :{i,4}");
            //}
            ////Работа с переменными разных типов
            //decimal i = 0.0m;
            //Console.Write("\n Введите i = ");
            //i=Convert.ToDecimal(Console.ReadLine());
            //Console.Write($"\n {i,18} {i,10:E} {i,10:F3}");
            ////Параметр типов
            //Console.Write($"In тип Decimal: {decimal.MinValue}:{decimal.MaxValue}:{sizeof(decimal)}");
            //Console.Write($"In тип float: {float.MinValue}:{float.MaxValue}:{sizeof(float)}");
            //Console.Write($"In тип byte: {byte.MinValue}:{byte.MaxValue}:{sizeof(byte)}");
            //Console.Write($"In тип int: {int.MinValue}:{int.MaxValue}:{sizeof(int)}");
            //Console.Write($"In тип Decimal: {char.MinValue}:{char.MaxValue}:{sizeof(char)}");

            ////работа с массивами
            //int[] array = null;
            //Console.Write("\n размерност массива = ");
            //int n=int.Parse(Console.ReadLine());
            //array= new int[n];
            //double[] array1= new double[n];
            //char[] array2 = new char[n] { '+', '-', 'z' };
            ////запольнение массив случайнной образом
            //Random R=new Random();
            //for (int i = 0i < array.Length; i++)
            //    array[i] = R.Next(-50, 50);
            //Console.WriteLine();
            //foreach (var x in array)
            //    Console.Write($"\t {x}");
            //input(array1);
            //output(array1);
            //reverse(array1);
            //output(array1);
            int n = 5;
            int[,] a = new int[n, n];
            Random R = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = R.Next(-30, 30);
                    Console.Write($"{a[i, j],8}");
                    Console.ReadKey();
                }
        }
    }
}