using System;


class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("1. Display a list of 10 sequential numbers\n");
            Console.WriteLine("2. Solve an arithmetic problem\n");
            Console.WriteLine("3. Exit\n");
            Console.Write("Enter your choice: \n");
            choice = Convert.ToInt32(Console.ReadLine());

            // The default command utilized bellow is a switch statement. it is used whenever a vale input does not correspond to the cases.

            switch (choice)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Console.WriteLine("Exiting...\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.\n");
                    break;
            }
        } while (choice != 3);
    }

    static void Option1()
    {
        Console.Write("Enter the starting number: \n");
        int start = Convert.ToInt32(Console.ReadLine());

        for (int i = start + 1; i <= start + 10; i++)
        {
            int result = i % 2 == 0 ? i * 3 : i * 2;
            Console.WriteLine($"Number: {i}, Result: {result}\n");
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
            Console.Write($"What is {num1} + {num2}? \n");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer != num1 + num2)
            {
                Console.WriteLine("Incorrect. Try again.\n");
            }
            else
            {
                Console.WriteLine("Correct! Well done.\n");
                Console.Write("Would you like another question? (Yes/No) \n");
                continueAnswer = Console.ReadLine();
            }

            // IsNullOrEmpty is a method that checks if a string is null or empty. It is used to check if the user input is empty or null.
            // ToLower is a method that converts a string to lowercase. It is used to convert the user input to lowercase so that the comparison is case-insensitive.

        } while (!string.IsNullOrEmpty(continueAnswer) && continueAnswer.ToLower() == "yes\n");
    }
}

