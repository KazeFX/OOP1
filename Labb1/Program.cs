/*
Labb av:
Peter Miscevic
Christoffer Bohlin
Max Jalderyd
Johannes Stålsjö
*/
class Program
{
    static decimal baseTariff = 49.0m;
    static bool membership = false;
    static bool insurance = false;
    static string sender = "";
    static int weight = 0;
    static decimal sum = 0.0m;
    static decimal value = 0.0m;
    static decimal weightTariff = 0.0m;
    static decimal heavyGoodsSurcharge = 0.0m;
    static decimal insuranceCost = 0.0m;


    public static void Main()
    {
        // Ok nått är fel med progammet, det startar inte ens. 
        // Hinner inte fixa, har möte med chefen om 5 min. Mvh Pelle Programmerare

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("VÄLKOMMEN TILL LASSES LAST 1.0\n");
            Console.WriteLine("1) Beräkna frakt för ett paket");
            Console.WriteLine("2) Beräkna frakt för flera paket från fil");
            Console.WriteLine("3) Avsluta\n");
            Console.Write("Val: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    userPrompt();
                    Console.WriteLine(calculateShippingPerPackage());
                    printReceipt();
                    resetFields();
                    break;

                case "2":
                    break;

                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
    }

    /*
    Prompts the user for all inputs required to start the calculateShippingPerPackage method
    */
    static void userPrompt()
    {
        Console.Write("Input sender: ");
        sender = Console.ReadLine();

        Console.Write("Input weight: ");
        weight = int.Parse(Console.ReadLine());

        Console.Write("Input value: ");
        value = decimal.Parse(Console.ReadLine());

        Console.Write("Are you a member?(yes/no): ");
        string memberPick = Console.ReadLine();
        if (memberPick.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
        {
            membership = true;
        }

        Console.Write("Do you want to insure the package? yes/no: ");
        string pick = Console.ReadLine();
        if (pick.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            insurance = true;
        }
    }

    /*
    Prints a receipt to the console with the current values of fields
    */
    static void printReceipt()
    {
        Console.WriteLine();
        Console.WriteLine("FRAKTVITTO");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Avsändare: {sender}");
        Console.WriteLine($"Vikt: {weight}");
        Console.WriteLine($"Innehållets värd: {value}");
        Console.WriteLine($"Medlem: {(membership ? "Ja" : "Nej")}");
        Console.WriteLine($"Försäkring: {(insurance ? "Ja" : "Nej")}");
        Console.WriteLine();
        Console.WriteLine($"{"Grundavgift:",-24}{baseTariff,8:0.00}");
        Console.WriteLine($"{"Viktavgift:",-24}{weightTariff,8:0.00}");
        Console.WriteLine($"{"Tunggodstillägg:",-24}{heavyGoodsSurcharge,8:0.00}");
        Console.WriteLine($"{"Försäkringsavgift:",-24}{insuranceCost,8:0.00}");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Totalt att betala: \t {sum}");
        Console.WriteLine();
    }

    /*
    Calculates shipping for a package
    */
    static decimal calculateShippingPerPackage()
    {
        sum = baseTariff;

        if (membership)
        {
            weightTariff += (weight - 5) * 10m;

            if (weight > 5 && weight <= 20)
            {
                sum += weightTariff;
            }
        }

        else // If not a member
        {
            weightTariff += (weight - 2) * 10m;

            if (weight > 2 && weight <= 20)
            {
                sum += weightTariff;
            }
        }

        if (weight > 20)
        {
            heavyGoodsSurcharge = (weight - 20) * 30m;
            weightTariff += heavyGoodsSurcharge;
            sum += weightTariff;
        }
        
        if (insurance)
        {
            insuranceCost = value * 0.01m;
            sum += insuranceCost;
        }

        return sum;
    }

    /*
    Resets all field variables to default values
    */
    static void resetFields()
    {
        membership = false;
        insurance = false;
        sender = "";
        weight = 0;
        sum = 0.0m;
        value = 0.0m;
        weightTariff = 0.0m;
        heavyGoodsSurcharge = 0.0m;
        insuranceCost = 0.0m;
    }
}
