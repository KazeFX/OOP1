
class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }


    public Book(string title, string author, int pages)
    {
        this.Title = title;
        this.Author = author;
        if (pages > 0)
        {
            this.Pages = pages;
        }
        else
        {
            this.Pages = 1;
        }
    }


    public void ShowInfo()
    {
        Console.WriteLine($"{this.Title} - {this.Author} - {this.Pages} pages.");
    }
}


class Player
{
    public string Name { get; private set; }
    public int Score { get; private set; }


    public Player(string name)
    {
        this.Name = name;
        this.Score = 0;
    }


    public void AddPoints(int points)
    {
        if (points > 0)
        {
            this.Score += points;
        }
    }


    public void ResetScore()
    {
        this.Score = 0;
    }


    public void ShowStatus()
    {
        Console.WriteLine($"{this.Name} - {this.Score}");
    }
}


class TempereatureSensor
{
    public string Location { get; private set; }
    public double Temperature { get; private set; }


    public TempereatureSensor(string location, double temperature)
    {
        this.Temperature = temperature;
        this.Location = location;
    }


    public void SetTemperature(double newTemperature)
    {
        if (newTemperature <= 60 && newTemperature >= -60)
        {
            this.Temperature = newTemperature;
        }
        else
        {
            Console.WriteLine("Temperature needs to be between -60 and 60.");
        }
    }
}