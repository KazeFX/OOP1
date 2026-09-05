// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Ange ditt användarnamn:");
//         string username = Console.ReadLine();

//         if (!string.IsNullOrWhiteSpace(username))
//         {
//             Console.WriteLine("Ange ditt lösenord:");
//             string password = Console.ReadLine();

//             if (!string.IsNullOrWhiteSpace(password))
//             {
//                 if (username == "admin" && password == "1234")
//                 {
//                     Console.WriteLine("Inloggning lyckades!");
//                 }
//                 else
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("Fel användarnamn eller lösenord.");
//                     Console.ResetColor();
//                 }
//             }
//             else
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("Lösenord får inte vara tomt!");
//                 Console.ResetColor();
//             }
//         }
//         else
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("Användarnamn får inte vara tomt!");
//             Console.ResetColor();
//         }
//     }
// }