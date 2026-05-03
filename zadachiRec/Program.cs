using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachiRec
{

    class Program
    {
        static void ReadList(List<int> list, int n)
        {
            if (n == 0) return;
            list.Add(int.Parse(Console.ReadLine()));
            ReadList(list, n - 1);
        }

        static void PrintList(List<int> list, int i = 0)
        {
            if (i == list.Count) return;
            Console.Write(list[i]);
            if (i < list.Count - 1) Console.Write(" >> ");
            PrintList(list, i + 1);
        }

        static int SeqRec(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return 3 * SeqRec(n - 1) - SeqRec(n - 2);
        }

        static int SeqIter(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            int n1 = 1, n2 = 2, ni = 0;
            for (int i = 3; i <= n; i++)
            {
                ni = 3 * n2 - n1;
                n1 = n2;
                n2 = ni;
            }
            return ni;
        }

        static long Fact(int p)
        {
            if (p <= 1) return 1;
            return p * Fact(p - 1);
        }

        static double Pow(double a, int n)
        {
            if (n == 0) return 1;
            return a * Pow(a, n - 1);
        }

        static int Min(int[] arr, int i = 0)
        {
            if (i == arr.Length - 1) return arr[i];
            int next = Min(arr, i + 1);
            return arr[i] < next ? arr[i] : next;
        }

        static void Geo(int a, int q, int n)
        {
            if (n == 0) return;
            Console.Write(a);
            if (n > 1) Console.Write(", ");
            Geo(a * q, q, n - 1);
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Задача 1: Въвеждане и отпечатване на List<int>");
            Console.Write("Въведи N: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Console.WriteLine("Въведи елементите:");
            ReadList(list, n);
            Console.WriteLine("Елементите са:");
            PrintList(list);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Задача 2: Редица Ni = 3*Ni-1 – Ni-2");
            Console.Write("Въведи n: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Итеративно: " + SeqIter(num));
            Console.WriteLine("Рекурсивно: " + SeqRec(num));
            Console.WriteLine();

            Console.WriteLine("Задача 3: Факториел");
            Console.Write("Въведи P: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Факториел = " + Fact(p));
            Console.WriteLine();

            Console.WriteLine("Задача 4: Степен на отрицателно число с четен показател");
            Console.Write("Въведи A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведи N (четно): ");
            int exp = int.Parse(Console.ReadLine());
            Console.WriteLine("Резултат = " + Pow(a, exp));
            Console.WriteLine();

            Console.WriteLine("Задача 5: Най-малко число в масив");
            Console.Write("Размер на масива: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Въведи елементите:");
            for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Минимумът е: " + Min(arr));
            Console.WriteLine();

            Console.WriteLine("Задача 6: Геометрична прогресия (a1=2, q=3)");
            Console.Write("Въведи брой елементи: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("Прогресия: ");
            Geo(2, 3, g);
            Console.WriteLine();
        }
    }
}