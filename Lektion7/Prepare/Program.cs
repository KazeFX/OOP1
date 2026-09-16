// using System.ComponentModel;
// using System.Diagnostics.Contracts;
// using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;

// public class Program
// {
//     static List<string> names = [];
//     static List<string> numbers = [];
//     public static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("ADDRESSBOK v1");
//             Console.WriteLine("-------------");
//             Console.WriteLine("1) Lägg till kontakt");
//             Console.WriteLine("2) Lista kontakter");
//             Console.WriteLine("3) Sök kontakt");
//             Console.WriteLine("4) Ta bort kontakt");
//             Console.WriteLine("5) Avsluta");
//             Console.WriteLine();
//             Console.Write("Val: ");
//             ConsoleKeyInfo input = Console.ReadKey(false);
//             Console.WriteLine();

//             if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
//             {
//                 Console.Write("Namn: ");
//                 string name = Console.ReadLine();
//                 Console.Write("Nummer: ");
//                 string number = Console.ReadLine();
//                 addContact(name, number);
//                 continue;
//             }

//             if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
//             {
//                 Console.WriteLine();
//                 listContacts();
//                 Console.WriteLine();
//             }

//             if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
//             {
//                 Console.WriteLine("Sök namn: ");
//                 Console.WriteLine($"Hittat: {searchContact(Console.ReadLine())}");
//                 Console.WriteLine();
//             }

//             if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
//             {
//                 Console.Write("Kontakt att ta bort: ");
//                 string nameToRemove = Console.ReadLine();
//                 removeContact(nameToRemove);
//                 Console.WriteLine($"{nameToRemove} borttagen.");
//                 Console.WriteLine();
//             }

//             if (input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5)
//             {

//                 Environment.Exit(0);
//             }
//         }
//     }


//     static void addContact(string name, string number)
//     {
//         names.Add(name);
//         numbers.Add(number);
//     }


//     static void listContacts()
//     {
//         for (int i = 0; i < names.Count; i++)
//         {
//             Console.WriteLine($"{names[i]} - {numbers[i]}");
//         }
//     }


//     static string searchContact(string name)
//     {
//         for (int i = 0; i < names.Count; i++)
//         {
//             if (names[i].Equals(name, StringComparison.CurrentCultureIgnoreCase))
//             {
//                 return $"Kontakt hittad: {names[i]} - {numbers[i]}";
//                 break;
//             }
//         }
//         return "Ingen kontakt hittad.";
//     }

//     static void removeContact(string name)
//     {
//         for (int i = 0; i < names.Count; i++)
//         {
//             if (names[i].Equals(name, StringComparison.CurrentCultureIgnoreCase))
//             {
//                 names.RemoveAt(i);
//                 numbers.RemoveAt(i);
//             }
//         }
//     }
// }