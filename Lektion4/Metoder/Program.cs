// void PrintHello()
// {
//     Console.WriteLine("Hello!");
// }

// PrintHello();
// PrintHello();
// PrintHello();

// void WriteMessageTo(string name)
// {
//     Console.WriteLine($"Yo {name}!");
// }

// WriteMessageTo("Robot");


// decimal CalculateTax(decimal amount)
// {
//     return amount / (100m / 30m);
// }

// //Console.Write("Input income: ");
// //Console.WriteLine($"Your tax is: {CalculateTax(decimal.Parse(Console.ReadLine()))}");

// void WriteWarning(string message)
// {
//     Console.ForegroundColor = ConsoleColor.White;
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.Write(message);
//     Console.ResetColor();
//     Console.WriteLine();
// }

// Console.WriteLine("NORMAL MESSAGE");
// WriteWarning("WARNING");
// Console.WriteLine("NORMAL MESSAGE");


// int GetIntFromUser(string input)
// {
//     string inputer = input;
//     while (true) {
        
//         if (int.TryParse(inputer, out int number))
//         {
//             return number;
//             break;
//         }
//         else
//         {
//             Console.Write("Please input an integer: ");
//             inputer = Console.ReadLine();
//             continue;
//         }
        
//     }
// }

// Console.Write("Input integer: ");
// string input = Console.ReadLine();
// Console.WriteLine(GetIntFromUser(input));

// using System.Text.RegularExpressions;

// string GetEmailFromUser(string email)
// {
//     string input = email;
    
//     while (true)
//     {
//         if (Regex.IsMatch(input, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
//         {
//             return input;
//             break;
//         }
//         else
//         {
//             Console.Write("Please enter a valid email: ");
//             input = Console.ReadLine();
//             continue;
//         }
//     }

// }

// Console.Write("Input email: ");
// Console.WriteLine(GetEmailFromUser(Console.ReadLine()));