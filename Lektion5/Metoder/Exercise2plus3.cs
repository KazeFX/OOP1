
// bool running = true;

// while (running) {
//     Console.WriteLine("*********************************");
//     Console.WriteLine("* 1. Visa dagens datum och tid");
//     Console.WriteLine("* 2. Lista alla namn");
//     Console.WriteLine("* 3. Avsluta");
//     Console.WriteLine("*********************************");

//     Console.Write("Val: ");
//     ConsoleKey pick = Console.ReadKey().Key;
//     Console.WriteLine();
//     Console.WriteLine("******************");
//     Console.WriteLine();

//     switch (pick)
//     {
//         case ConsoleKey.D1:
//         case ConsoleKey.NumPad1:
//             PrintDateInBlue();
//             Console.WriteLine();
//             break;
//         case ConsoleKey.D2:
//         case ConsoleKey.NumPad2:
//             PrintLines();
//             Console.WriteLine();
//             break;
//         case ConsoleKey.D3:
//         case ConsoleKey.NumPad3:
//             running = false;
//             Environment.Exit(0);
//             break;
//     }
// }

// void PrintDateInBlue()
// {
//     Console.ForegroundColor = ConsoleColor.Blue;
//     Console.WriteLine(DateTime.Now.ToString());
//     Console.ResetColor();
// }


// void PrintLines() {
//     string currentDirectory = Directory.GetCurrentDirectory();

//     string sourcePath = Path.Combine(currentDirectory, "../../../Metoder/", "input04.txt");

//     string[] listOfNames = File.ReadAllLines(sourcePath);

//     for (int i = 0; i < listOfNames.Length; i++)
//     {
//         if (!listOfNames[i].IsWhiteSpace())
//         {
//             Console.WriteLine(listOfNames[i]);
//         } 
//     }
// }