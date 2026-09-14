public class Program
{
    static List<string> names = [];
    static List<string> numbers = [];
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("ADDRESSBOK v1");
            Console.WriteLine("-------------");
            Console.WriteLine("1) Lägg till kontakt");
            Console.WriteLine("2) Lista kontakter");
            Console.WriteLine("3) Avsluta");
            Console.WriteLine();
            Console.Write("Val: ");
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Write("Namn: ");
                string name = Console.ReadLine();
                Console.Write("Nummer: ");
                string number = Console.ReadLine();
                addContact(name, number);
                continue;
            }

            if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                listContacts();
            }
        }
    }

    static void addContact(string name, string number)
    {
        names.Add(name);
        numbers.Add(number);
    }

    static void listContacts()
    {
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{names[i]} - {numbers[i]}");
        }
    }

}