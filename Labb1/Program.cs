class Program
{




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
                    bool membership = false;
                    bool insurance = false;

                    Console.Write("Input weight: ");
                    int inputWeight = int.Parse(Console.ReadLine());

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

                    Console.WriteLine(calculateShippingPerPackage(inputWeight, membership, insurance));
                    break;

                case "2":

                    break;

                case "3":
                    Environment.Exit(0);
                    break;


            }
        }
    }

    // public void userInfo()
    // {
    //     Console.Write("Are you a member?(yes/no): ");
    //     string memberPick = Console.ReadLine();
    //     if (memberPick.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
    //     {
    //         membership = true;
    //     }

    //     Console.Write("Do you want to insure the package? yes/no: ");
    //     string pick = Console.ReadLine();
    //     if (pick.Equals("yes", StringComparison.OrdinalIgnoreCase))
    //     {
    //         insurance = true;
    //     }

    // }
    static decimal calculateShippingPerPackage(int weight, bool membership, bool insurance)
    {
        decimal sum = 49.0m;

        if (membership)
        {
            if (weight <= 5 && weight >= 0)
            {
                sum = sum;

            }
            else if (weight > 20)
            {
                sum += (weight - 20) * 40;
            }
            else if (weight <= 20 && weight > 5)
            {
                sum += (weight - 5) * 10;
            }

        }

        else
        {
            if (weight <= 2 && weight >= 0)
            {
                sum = sum;

            }
            else if (weight > 20)
            {
                sum += (weight - 20) * 40;
            }
            else if (weight <= 20 && weight > 5)
            {
                sum += (weight - 2) * 10;
            }

        }

        if (insurance)
        {
            sum *= 1.01m;
        }
        return sum;
    }
}