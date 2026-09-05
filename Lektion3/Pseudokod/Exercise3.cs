/*
SKAPA en variabel som heter SUMMA och sätt den till 0
LOOPA oändligt
    SKAPA en tom sträng som heter INPUT
    LÄS in en rad från användaren och spara i INPUT
    OM INPUT är lika med "sluta" (case insensitive)
        AVBRYT loopen
    ANNARS OM INPUT är tom
        SKRIV UT "Du måste mata in något!"
    ANNARS OM INPUT går att tolka som ett heltal
        ADDERA heltalet till SUMMA
    ANNARS
        SKRIV UT "Det där var inte ett giltigt tal!"
SKRIV UT "Summan av talen är: " + SUMMA
*/

// public class Exercise3
// {
//     public static void Main()
//     {
//         int sum = 0;

//         while (true)
//         {
//             string input = null;
//             Console.WriteLine("Mata in tal att summera: ");
//             input = Console.ReadLine();
//             if (string.Equals(input, "sluta", StringComparison.OrdinalIgnoreCase))
//             {
//                 break;
//             }
//             else if (string.IsNullOrWhiteSpace(input)) {
//                 Console.WriteLine("Du måste mata in något!");
//             }
//             else if (int.TryParse(input, out int number))
//             {
//                 sum += number;
//             }
//             else
//             {
//                 Console.WriteLine("Det där var inte ett giltigt tal!");
//             }
//         }
//         Console.WriteLine($"Summan av talen är: {sum}");
//     }
// }