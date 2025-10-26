using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_s_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int izbor = 0;
            do
            {

                Console.WriteLine("____________MENU_______________");

                Console.WriteLine("1. chisloto dali e prosto ili ne");
                Console.WriteLine("2. sborat ot 1 do vuvedenoto chislo");
                Console.WriteLine("3. da se vuvejdat chisla > 0 i da se subirat vsichkite vuvedeni chisla");
                Console.WriteLine("4.");

                Console.WriteLine("");

                Console.Write("vuvedi chislo ot 1-4: ");
                izbor = int.Parse(Console.ReadLine());

            }
            while (izbor > 4 || izbor < 0);

            switch (izbor)
            {
                case 1:
                    Console.Write("Vuvedi chislo: ");
                    int num = int.Parse(Console.ReadLine());
                    int flag = 0;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                            flag = 1;
                    }
                    if (flag == 0) 
                    { 
                        Console.WriteLine($"{num} e prosto chislo");
                    }
                    else Console.WriteLine($"{num} e slojno chislo");


                    break;

                case 2:
                    Console.Write("Vuvedi chislo: ");
                    int num1 = int.Parse(Console.ReadLine());
                    int sum = 0;
                    for (int i = 1; i <= num1; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);
                    break;

                case 3:
                    Console.Write("Vuvedi chislo/a: ");
                    int sum1 = 0;
                    int num2;

                    do
                    {
                        num2 = int.Parse(Console.ReadLine());
                        if (num2 > 0) sum1 += num2;
                    } while (num2 > 0);

                    Console.WriteLine(sum1);
                    break;

                case 4:
                    Console.WriteLine("ne razbrah kakvo ne iska ");
                    break;

            }
        }

        
    }
}
