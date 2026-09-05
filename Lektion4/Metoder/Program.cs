void PrintHello()
{
    Console.WriteLine("Hello!");
}

PrintHello();
PrintHello();
PrintHello();

void WriteMessageTo(string name)
{
    Console.WriteLine($"Yo {name}!");
}

WriteMessageTo("Robot");


decimal CalculateTax(decimal amount)
{
    return amount / (100m / 30m);
}

//Console.Write("Input income: ");
//Console.WriteLine($"Your tax is: {CalculateTax(decimal.Parse(Console.ReadLine()))}");

void WriteWarning(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Write(message);
    Console.ResetColor();
    Console.WriteLine();
}

Console.WriteLine("NORMAL MESSAGE");
WriteWarning("WARNING");
Console.WriteLine("NORMAL MESSAGE");

int GetIntFromUser(string input)
{

   

    if (int.TryParse(input))
    {
        return int.Parse(input);
    }

}