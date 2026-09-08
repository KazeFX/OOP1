// class Program
// {
//     static void Main()
//     {
//         Console.Write("Ange ditt användarnamn: ");
//         string username = Console.ReadLine();

//         Console.Write("Ange ditt lösenord: ");
//         string password = Console.ReadLine();

//         if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) 
//         {
//             ShowErrorMessage("Användarnamn och lösenord får inte vara tomt!");
//         }
        
//         if (username == "admin" && password == "1234")
//         {
//             Console.WriteLine("Inloggning lyckades!");
//         }
//         else
//         {
//             ShowErrorMessage("Fel användarnamn eller lösenord.");
//         }
//     }
//     static void ShowErrorMessage(string message) {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.Write(message);
//         Console.WriteLine();
//         Console.ResetColor();
//     }
// }