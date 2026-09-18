class Person
{
    public string Name { get; private set; }
    public Pet Pet { get; private set; }

    public Person(string name, Pet pet)
    {
        this.Name = name;
        this.Pet = pet;
    }

    void Present()
    {
        Console.WriteLine($"Jag heter {this.Name} och mitt husdjur heter {this.Pet.Name} och är en {this.Pet.Species}");
    }
}


class Pet
{
    public string Name { get; private set; }
    public string Species { get; private set; }

    public Pet(string name, string species)
    {
        this.Name = name;
        this.Species = species;
    }
}

class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    void ShowInfo()
    {
        Console.WriteLine($"{this.Name} - {this.Price}");
    }



}

class Customer
{
    public string Name { get; private set; }
    public decimal Balance { get; private set; }

    public Customer(string name, decimal balance)
    {
        this.Name = name;
        this.Balance = balance;
    }

    public void Buy(Product product)
    {
        if (product.Price <= this.Balance)
        {
            Balance -= product.Price;
        }
        else
        {
            Console.WriteLine("Not enought balance!");
        }

    }

    public decimal ShowMoney()
    {
        return this.Balance;
    }
}


class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsBorrowerd { get; private set; }

    public void Borrow()
    {
        this.IsBorrowerd = true;
    }

    public void Return()
    {
        this.IsBorrowerd = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{this.Title} by {this.Author}");
    }
}


class Library
{

}


class Program
{
    public static void Main()
    {
        Customer newCustomer = new Customer("Hej", 100.0m);
        Product newProduct = new Product("Cola", 20.0m);

        Console.WriteLine(newCustomer.ShowMoney());
        newCustomer.Buy(newProduct);
        Console.WriteLine(newCustomer.ShowMoney());
    }
}