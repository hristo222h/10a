using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("zadacha 1:");

            Stack<string> plodove = new Stack<string>();

            plodove.Push("Apple");
            plodove.Push("Banana");
            plodove.Push("Cherry");

            while (plodove.Count > 0)
            {
                Console.WriteLine(plodove.Pop());
            }
            Console.WriteLine();

            Console.WriteLine("zadacha 2:");

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine();

            Console.WriteLine("zadacha 3:");

            Stack<char> stack = new Stack<char>();
            bool pravilno = true;

            Console.Write("Въведи скоби: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    stack.Push('(');
                }
                else if (text[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        pravilno = false;
                        break;
                    }

                    stack.Pop();
                }
            }

            if (stack.Count != 0)
            {
                pravilno = false;
            }

            if (pravilno)
            {
                Console.WriteLine("vqrno");
            }
            else
            {
                Console.WriteLine("gresno");
            }
            Console.WriteLine();

            Console.WriteLine("zadacha 4:");

            Console.Write("Vuvedi chislo: ");
            int number = int.Parse(Console.ReadLine());

            Stack<int> deschislo = new Stack<int>();

            while (number > 0)
            {
                deschislo.Push(number % 2);
                number /= 2;
            }

            Console.Write("dvoitchno: ");
            while (deschislo.Count > 0)
            {
                Console.Write(deschislo.Pop());
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("zadacha 5:");

            Queue<int> queue1 = new Queue<int>();
            Stack<int> stack1 = new Stack<int>();

            Console.Write("vuvedi broi: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("vuvedi celi chisla:");
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                queue1.Enqueue(num);
            }

            while (queue1.Count > 0)
            {
                stack1.Push(queue1.Dequeue());
            }

            Console.Write("obraten red: ");
            while (stack1.Count > 0)
            {
                Console.Write(stack1.Pop() + " ");
            }

            Console.WriteLine();

            Console.WriteLine("zadacha 6:");
        }
    }
}
