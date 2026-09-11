using System.Runtime.InteropServices;

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

    static void printReceipt()
    {
        Console.WriteLine("FRAKTVITTO");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Avsändare: {sender}");
        Console.WriteLine($"Vikt: {weight}");
        Console.WriteLine($"Innehållets värd: {value}");
        Console.WriteLine($"Medlem: {membership}");
        Console.WriteLine($"Försäkring: {insurance}");
        Console.WriteLine();
        Console.WriteLine($"Grundavgift: \t {baseTariff,-10}");
        Console.WriteLine($"Viktavgift: \t {weightTariff,-10}");
        Console.WriteLine($"Tunggodstillägg: \t {heavyGoodsSurcharge,-10}");
        Console.WriteLine($"Försäkringsavgift: \t {insuranceCost,-10}");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Totalt att betala: \t {sum}");
    }

    static decimal calculateShippingPerPackage()
    {
        sum = baseTariff;

        if (membership)
        {
            if (weight > 5 && weight <= 20)
            {
                weightTariff += (weight - 5) * 10m;
                sum += weightTariff;
            }
            else if (weight > 20)
            {
                weightTariff = 150m;
                heavyGoodsSurcharge = (weight - 20) * 30m;
                weightTariff += heavyGoodsSurcharge;
                sum += weightTariff;
            }
            else
            {
                if (weight > 5 && weight <= 20)
                {
                    weightTariff += (weight - 2) * 10m;
                    sum += weightTariff;
                }
                else if (weight > 20)
                {
                    weightTariff = 180m;
                    heavyGoodsSurcharge = (weight - 20) * 30m;
                    weightTariff += heavyGoodsSurcharge;
                    sum += weightTariff;
                }
            }
        }

        if (insurance)
        {
            insuranceCost = value * 0.01m;
            sum += insuranceCost;
        }

        return sum;
    }

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