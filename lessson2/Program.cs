using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geli Magacaaga: ");
            string name = Console.ReadLine();

            Console.Write("Geli ID gaaga: ");
            string id = Console.ReadLine();

            Console.WriteLine("\n Dooro nooca xisaabta:");
            Console.WriteLine("1. Kudar");
            Console.WriteLine("2. Kajar");
            Console.WriteLine("3. Kudhufo");
            Console.WriteLine("4. Qaybi");
            Console.Write("Dooro (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            int correct = 0;
            int total = 10;

            Random rand = new Random();

            for (int i = 1; i <= total; i++)
            {
                int a = rand.Next(1, 20);
                int b = rand.Next(1, 20);
                int answer = 0;
                int userAnswer = 0;

                switch (choice)
                {
                    case 1: // Kudar
                        Console.Write($"Q{i}: {a} + {b} = ");
                        answer = a + b;
                        break;
                    case 2: // Kajar
                        Console.Write($"Q{i}: {a} - {b} = ");
                        answer = a - b;
                        break;
                    case 3: // Kudhufo
                        Console.Write($"Q{i}: {a} * {b} = ");
                        answer = a * b;
                        break;
                    case 4: // Qaybi
                        a = a * b; // si b ay u qaybin karto a
                        Console.Write($"Q{i}: {a} / {b} = ");
                        answer = a / b;
                        break;
                    default:
                        Console.WriteLine(" Doorasho khaldan.");
                        return;
                }

                try
                {
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(" Kaliya tiro gelin.");
                    continue;
                }

                if (userAnswer == answer)
                {
                    Console.WriteLine(" Sax!\n");
                    correct++;
                }
                else
                {
                    Console.WriteLine($" Khalad. Jawaabta saxda ah waa: {answer}\n");
                }
            }

            int wrong = total - correct;
            int percent = (correct * 100) / total;

            Console.WriteLine("===== Natiijada =====");
            Console.WriteLine($" Magaca: {name}");
            Console.WriteLine($" ID: {id}");
            Console.WriteLine($" Sax: {correct}");
            Console.WriteLine($" Khalad: {wrong}");
            Console.WriteLine($" Boqolley: {percent}%");
        }
    }
}
