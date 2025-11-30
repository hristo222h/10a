using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasirane
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Брой играчи: ");
            int playerCount = int.Parse(Console.ReadLine());

            Console.Write("Брой игри: ");
            int gameCount = int.Parse(Console.ReadLine());

            string[] playerNames = new string[playerCount];
            int[,] scores = new int[playerCount, gameCount];

            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"Играч {i + 1}:");
                Console.Write("Име: ");
                playerNames[i] = Console.ReadLine();

                Console.Write("Точки: ");
                string[] inputScores = Console.ReadLine().Split();

                for (int j = 0; j < gameCount; j++)
                {
                    scores[i, j] = int.Parse(inputScores[j]);
                }
            }

            Console.WriteLine();

            int maxPoints = -1;
            string winnerName = "";

            for (int i = 0; i < playerCount; i++)
            {
                int total = 0;

                for (int j = 0; j < gameCount; j++)
                {
                    total += scores[i, j];
                }

                Console.WriteLine($"{playerNames[i]} – общо: {total}");

                if (total > maxPoints)
                {
                    maxPoints = total;
                    winnerName = playerNames[i];
                }
            }

            Console.WriteLine($"Победител: {winnerName} ({maxPoints} точки)");

        }
    }
}
