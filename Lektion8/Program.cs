using System.ComponentModel;
using System.Runtime.CompilerServices;

class Book
{
    public string title;
    public string author;

    public Book(string bookTitle, string bookAuthor)
    {
        this.title = bookTitle;
        this.author = bookAuthor;
    }
}

class Dog
{
    public string name;
    public int age;

    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Jag heter {name} och är {age} år.");
    }
}



class Car
{
    public string brand;
    public int speed;

    public Car(string brand, int speed)
    {
        this.brand = brand;
        this.speed = speed;
    }

    public void Accelerate()
    {
        speed += 10;
    }

    public void Brake()
    {
        if (this.speed > 0)
        {
            speed -= 10;
        }
    }
}


class BankAccount
{
    public string owner;
    public int balance;

    public BankAccount(string owner, int balance)
    {
        this.owner = owner;
        this.balance = balance;
    }

    public void Deposit(int amount)
    {
        balance += amount;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Owner: {this.owner} - Balance: {this.balance}");
    }



}
class Program
{
    public static void Main()
    {
        Book book1 = new Book("Dune", "Frank Herbert");
        Book book2 = new Book("Frankenstein", "Mary Shelley");

        Console.WriteLine($"{book1.title} {book2.title} {book1.author} {book1.author}");

        Dog bestDog = new Dog("Oscar", 12);
        bestDog.Introduce();

        Car newCar = new Car("BMW", 10);
        Console.WriteLine(newCar.speed);
        newCar.Accelerate();
        newCar.Accelerate();
        newCar.Accelerate();
        Console.WriteLine(newCar.speed);
        newCar.Brake();
        newCar.Brake();


        BankAccount bankaccount = new BankAccount("Lol", 100);
        bankaccount.ShowBalance();
        bankaccount.Deposit(100);
        bankaccount.ShowBalance();

    }
}