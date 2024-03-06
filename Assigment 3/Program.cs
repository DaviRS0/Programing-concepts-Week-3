using System;


class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("1. Display a list of 10 sequential numbers");
            Console.WriteLine("2. Solve an arithmetic problem");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        } while (choice != 3);
    }

    static void Option1()
    {
        Console.Write("Enter the starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        for (int i = start + 1; i <= start + 10; i++)
        {
            int result = i % 2 == 0 ? i * 3 : i * 2;
            Console.WriteLine($"Number: {i}, Result: {result}");
        }
    }

    static void Option2()
    {
        Random rand = new Random();
        string continueAnswer = string.Empty;

        do
        {
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            Console.Write($"What is {num1} + {num2}? ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num1 + num2)
            {
                Console.WriteLine("Correct! Well done.");
            }
            else
            {
                Console.WriteLine("Incorrect. Try again.");
                continue;
            }

            Console.Write("Would you like another question? (Yes/No) ");
            continueAnswer = Console.ReadLine();
        } while (!string.IsNullOrEmpty(continueAnswer) && continueAnswer.ToLower() == "yes");
    }

}

