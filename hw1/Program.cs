using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ToOctalString();
        }
        static void ToOctalString()
        {
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 8;
                number /= 8;
                result = remainder.ToString() + result; // додаємо остачу до результату
            }
            Console.WriteLine($"{result}");

        }
        static void CalculationTask()
        {
            Console.Write("Введіть x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введіть y : ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введіть z : ");
            double z = double.Parse(Console.ReadLine());
            double a, b, c;
            a = (x * y) / z + z / (x * y);
            b = Math.Sin(((x * y) + z) / z) - Math.Cos(1 + (z / (x * y))) + 0.5;
            c = 2 - Math.Sqrt(Math.Pow(((x * y) / z) + (z / (x * y)), 2) + 5);
            Console.WriteLine($"a {a}, b {b}, c{c}");
            double min = a;

            if (b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }

            Console.WriteLine($"Minimal value is {min}");
        }
        static void MatrixTask()
        {
            int[,] matrixA = new int[5, 7]; 
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrixA[i, j] = rnd.Next(100);
                }
            }

            Console.WriteLine("Матриця A:");
            PrintMatrix(matrixA);

            int[] vectorB = new int[5]; // ініціалізуємо вектор розміру 5

            // рахуємо кількість парних елементів у кожному рядку і заповнюємо вектор B
            for (int i = 0; i < 5; i++)
            {
                int count = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (matrixA[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
                vectorB[i] = count;
            }

            Console.WriteLine("Вектор B:");
            PrintVector(vectorB); 

            int maxIndex = 0;
            for (int i = 1; i < 5; i++)
            {
                if (vectorB[i] > vectorB[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Номер максимального елемента вектора B: {maxIndex}");
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
