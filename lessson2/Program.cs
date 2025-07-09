using System;

class StudentMathQuiz
{
    static void Main()
    {
        // 1. Get student info
        (string name, string id) = GetStudentInfo();

        // 2. Get math operation
        int choice = SelectOperation();

        // 3. Ask questions and get result
        int totalQuestions = 10;
        int correctAnswers = AskQuestions(choice, totalQuestions);

        // 4. Show result
        DisplayResult(name, id, correctAnswers, totalQuestions);
    }

    // Method to get student info
    static (string, string) GetStudentInfo()
    {
        Console.Write("Geli Magaca: ");
        string name = Console.ReadLine();

        Console.Write("Geli ID: ");
        string id = Console.ReadLine();

        return (name, id);
    }

    // Method to select operation
    static int SelectOperation()
    {
        Console.WriteLine("\n Dooro nooca xisaabta:");
        Console.WriteLine("1. Kudar");
        Console.WriteLine("2. Kajar");
        Console.WriteLine("3. Kudhufo");
        Console.WriteLine("4. Qaybi");
        Console.Write("Dooro (1-4): ");

        int choice;
        bool valid = int.TryParse(Console.ReadLine(), out choice);
        if (!valid || choice < 1 || choice > 4)
        {
            Console.WriteLine(" Doorasho khaldan.");
            Environment.Exit(0);
        }

        return choice;
    }

    // Method to ask questions
    static int AskQuestions(int choice, int total)
    {
        Random rand = new Random();
        int correct = 0;

        for (int i = 1; i <= total; i++)
        {
            int a = rand.Next(1, 20);
            int b = rand.Next(1, 20);
            int answer = 0;

            if (choice == 4) a = a * b; // Make sure a is divisible by b for division

            switch (choice)
            {
                case 1: Console.Write($"Q{i}: {a} + {b} = "); answer = a + b; break;
                case 2: Console.Write($"Q{i}: {a} - {b} = "); answer = a - b; break;
                case 3: Console.Write($"Q{i}: {a} * {b} = "); answer = a * b; break;
                case 4: Console.Write($"Q{i}: {a} / {b} = "); answer = a / b; break;
            }

            int userAnswer;
            bool isValid = int.TryParse(Console.ReadLine(), out userAnswer);
            if (!isValid)
            {
                Console.WriteLine(" Kaliya tiro gelin.\n");
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

        return correct;
    }

    // Method to display result
    static void DisplayResult(string name, string id, int correct, int total)
    {
        int wrong = total - correct;
        int percent = (correct * 100) / total;

        Console.WriteLine("===== Natiijada =====");
        Console.WriteLine($"👤 Magaca: {name}");
        Console.WriteLine($"🆔 ID: {id}");
        Console.WriteLine($"✅ Sax: {correct}");
        Console.WriteLine($"❌ Khalad: {wrong}");
        Console.WriteLine($"🎯 Boqolley: {percent}%");
    }
}