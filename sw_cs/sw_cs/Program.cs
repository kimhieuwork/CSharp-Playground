// See https://aka.ms/new-console-template for more information
    int choice;
    Console.Write("Enter a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Enter b: ");
    int b = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine("\nYou have two numbers: a and b");
        Console.WriteLine("Choose your choice:");
        Console.WriteLine("1. a + b");
        Console.WriteLine("2. a - b");
        Console.WriteLine("3. a * b");
        Console.WriteLine("4. a / b");
        Console.WriteLine("Other key: Exit");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"a + b = {a + b}");
                break;
            case 2:
                Console.WriteLine($"a - b = {a - b}");
                break;
            case 3:
                Console.WriteLine($"a * b = {a * b}");
                break;
            case 4:
                if (b != 0)
                    Console.WriteLine($"a / b = {(double)a / b}");
                else
                    Console.WriteLine("Error: Division by zero!");
                break;
            default:
                Console.WriteLine("Đang thoát chương trình...");
                break;
        }
    } while (choice > 0 && choice < 5);