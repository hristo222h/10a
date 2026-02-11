using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList class10A = new ArrayList();

            ArrayList s1 = new ArrayList();
            s1.Add("Ivan");
            s1.Add(new int[] { 5, 6, 6 });

            ArrayList s2 = new ArrayList();
            s2.Add("Maria");
            s2.Add(new int[] { 6, 6, 5 });

            ArrayList s3 = new ArrayList();
            s3.Add("Georgi");
            s3.Add(new int[] { 4, 5, 5 });

            class10A.Add(s1);
            class10A.Add(s2);
            class10A.Add(s3);

            int studentsCount = class10A.Count;
            int testsCount = 3;

            List<string> names = new List<string>();
            int[,] grades = new int[studentsCount, testsCount];

            for (int i = 0; i < class10A.Count; i++)
            {
                ArrayList student = (ArrayList)class10A[i];

                string name = "";
                int[] studentGrades = null;

                foreach (object item in student)
                {
                    if (item is string)
                        name = (string)item;

                    if (item is int[])
                        studentGrades = (int[])item;
                }

                if (name != "" && studentGrades != null)
                {
                    names.Add(name);

                    for (int j = 0; j < testsCount; j++)
                        grades[i, j] = studentGrades[j];
                }
            }


            for (int i = 0; i < studentsCount; i++)
            {
                double sum = 0;

                for (int j = 0; j < testsCount; j++)
                    sum += grades[i, j];

                double avg = sum / testsCount;

                Console.WriteLine($"{names[i]} -> Average: {avg:F2}");
            }
            for (int j = 0; j < testsCount; j++)
            {
                double sum = 0;

                for (int i = 0; i < studentsCount; i++)
                    sum += grades[i, j];

                Console.WriteLine($"Test {j + 1} average: {(sum / studentsCount):F2}");
            }
            Console.Write("Enter letter: ");
            char letter = char.ToUpper(Console.ReadLine()[0]);

            for (int i = 0; i < names.Count; i++)
            {
                if (char.ToUpper(names[i][0]) == letter)
                    Console.WriteLine(names[i]);
            }



        }
    }
}
