/*
Labb av:
Peter Miscevic
Christoffer Bohlin
Max Jalderyd
Johannes Stålsjö
*/
class Program
{
    static decimal destinationFee = 0.0m;
    static bool membership = false;
    static bool insurance = false;
    static string sender = "";
    static int weight = 0;
    static decimal sum = 0.0m;
    static decimal value = 0.0m;
    static decimal weightTariff = 0.0m;
    static decimal heavyGoodsSurcharge = 0.0m;
    static decimal insuranceCost = 0.0m;
    static string destination = "";
    static string destinationsFilePath = "../../../destinationer.csv";
    static string receiptsFilePath = "../../../";
    static decimal bulkShippingCost = 0.0m;


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
                    getDestinationCost(destination);
                    calculateShippingPerPackage();
                    printReceipt();
                    resetFields();
                    break;

                case "2":
                    calculateBulkShipping();
                    printReceipt();
                    bulkShippingCost = 0.0m; // Reset field
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
        bool running = true;
        while (running)
        {
            Console.Write("Input sender: ");
            sender = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sender))
            {
                Console.WriteLine("Sender can't be empty or whitespace.");
                continue;
            }

            Console.Write("Destination country: ");
            destination = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(destination))
            {
                Console.WriteLine("Sender can't be empty or whitespace.");
                continue;
            }

            Console.Write("Input weight: ");
            string weightInput = Console.ReadLine();
            if (!int.TryParse(weightInput, out var weightResult) || weightResult < 0)
            {
                Console.WriteLine("Weight needs to be a number and can't be negative.");
                continue;
            }
            weight = weightResult;

            Console.Write("Input value: ");
            string valueInput = Console.ReadLine();
            if (!decimal.TryParse(valueInput, out var valueResult) || valueResult < 0)
            {
                Console.WriteLine("Value needs to be a number and can't be negative.");
                continue;
            }
            value = valueResult;

            Console.Write("Are you a member?(yes/no): ");
            string memberPick = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(memberPick))
            {
                Console.WriteLine("Member can't be empty or whitespace. Input Yes or No.");
                continue;
            }
            else
            {
                if (memberPick.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    membership = true;
                }
            }

            Console.Write("Do you want to insure the package? yes/no: ");
            string pick = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(pick))
            {
                Console.WriteLine("Membership can't be empty or whitespace. Input Yes or No.");
                continue;
            }
            else
            {
                if (pick.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    insurance = true;
                }
            }
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
        Console.WriteLine($"{"Grundavgift:",-24}{destinationFee,8:0.00}");
        Console.WriteLine($"{"Viktavgift:",-24}{weightTariff,8:0.00}");
        Console.WriteLine($"{"Tunggodstillägg:",-24}{heavyGoodsSurcharge,8:0.00}");
        Console.WriteLine($"{"Försäkringsavgift:",-24}{insuranceCost,8:0.00}");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Totalt att betala: \t {sum}");
        Console.WriteLine($"Totalt att betala för bulk: \t {bulkShippingCost}");
        Console.WriteLine();
    }


    /*
    Calculates shipping for a package
    */
    static void calculateShippingPerPackage()
    {
        sum = destinationFee;

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
            heavyGoodsSurcharge = (weight - 20) * 40m;
            weightTariff += heavyGoodsSurcharge;
            sum += weightTariff;
        }

        if (insurance)
        {
            insuranceCost = value * 0.01m;
            sum += insuranceCost;
        }
        bulkShippingCost += sum;
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

    static void setFields(string sender, int weight, decimal value, bool membership, bool insurance, string destination)
    {
        sender = sender;
        destination = destination;
        weight = weight;
        value = value;
        membership = membership;
        insurance = insurance;
    }

    /*
    Updates the destination field.
    */
    static void getDestinationCost(string destination)
    {
        string[] file = File.ReadAllLines(destinationsFilePath);
        foreach (string line in file)
        {
            string[] splitLine = line.Split(";");
            if (splitLine[0].Equals(destination, StringComparison.CurrentCultureIgnoreCase))
            {
                destinationFee = decimal.Parse(splitLine[1]);
            }
        }
    }

    static void calculateBulkShipping()
    {
        while (true)
        {
            Console.Write("Input file name for bulk: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("File name can't be empty or whitespace.");
                continue;
            }
            receiptsFilePath += input;

            string[] file = File.ReadAllLines(receiptsFilePath);
            foreach (string line in file)
            {
                string[] splitLine = line.Split(";");
                bool membr = false;
                bool insur = false;
                if (splitLine[3].Equals("ja", StringComparison.CurrentCultureIgnoreCase))
                {
                    membr = true;
                }
                if (splitLine[4].Equals("nej", StringComparison.CurrentCultureIgnoreCase))
                {
                    insur = true;
                }

                setFields(splitLine[0], int.Parse(splitLine[1]), decimal.Parse(splitLine[2]), membr, insur, splitLine[5]);
                calculateShippingPerPackage();
                resetFields();
            }
            break;
        }
    }
}