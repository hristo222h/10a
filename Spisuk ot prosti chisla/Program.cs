using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisuk_ot_prosti_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //иначе ми дава въпросителни
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Въведи до колко да е списъкът: ");
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                int flag = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    list.Add(i);
                }
            }

            Console.WriteLine("Списък от прости числа");
            foreach (int chislo in list)
            {
                Console.Write(chislo + " ");
            }
            Console.WriteLine();

        }
    }
}
