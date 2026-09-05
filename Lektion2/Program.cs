// using System.Numerics;



// string greeting = "Hello";

// //--------------------------------
// //Variablel

// Console.WriteLine(greeting);


// string greeting2 = ", World!";

// Console.WriteLine(greeting + greeting2);


// Console.WriteLine("What is your name?");
// string name = Console.ReadLine();

// Console.WriteLine("Hello, " + name + "!");


// int one = 4;
// int two = 5;
// Console.WriteLine(one + two);


// Console.WriteLine("How old are you?: ");
// var age = int.Parse(Console.ReadLine());
// int numberOfLeaps = age / 4;
// int ageInDays = (age - numberOfLeaps) + (numberOfLeaps * 366);

// Console.WriteLine($"You are {ageInDays}");


// int div = 3;

// Console.WriteLine(age / div);

// int plopp = 2147483647;
// plopp++;
// Console.WriteLine(plopp);
// //Blir overflow, vanlig int kan inte hålla värden större än ursprungliga plopp.

// var userAge = 20;

// if (userAge < 18)
// {
//     Console.WriteLine("Du får inte ta körtkort än. :(");
// }
// else if (userAge == 18)
// {
//     Console.WriteLine("Du är exakt 18 år!");
// }
// else
// {
//     Console.WriteLine("Du får ta körkort!");
// }

// string[] names = ["Darth Vader", "Jean Luc Picard", "Batman", "Cyclops", "Dr X"];

// foreach (String nameOne in names) {
//     Console.WriteLine(nameOne);
// }

// string[] arrayOne = ["Dana Scully", "Sarah Connor", "Eleven"];
// int[] arrayTwo = [20, 30, 40];

// for (int i = 0; i < arrayOne.Length; i++)
// {
//     Console.WriteLine($"{arrayOne[i]}, {arrayTwo[i]}"
//     );
// }

// List<string> nameList = new();

// while (nameList.Count < 3)
// {
//     Console.WriteLine("Put in a name!");
//     nameList.Add(Console.ReadLine());
// }
// int i = 1;
// foreach (string name in nameList)
// {
//    Console.WriteLine($"Person {i++}: {name}");
// }


// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

// int value;

// Console.WriteLine("Multiplikationstabellen för: ");
// value = int.Parse(Console.ReadLine());

// int i = 1;
// while (i <= 12)
// {
//     Console.WriteLine(i * value);
//     i++;
// }

// for (int i = 1; i <= 10; i++)
// {
//     if (i >= 3 && i <= 7)
//     {
//         if (i % 2 == 0)
//         {
//             Console.WriteLine("Burr");
//         }
//         else
//         {
//             Console.WriteLine("Birr");
//         }
//     }
// }


// for (int i = 1; i <= 4; i++)
// {
//     for (int j = 1; j <= i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// int stars = 4;
// for (int line = 1; line <= stars; line++)
// {
//     Console.Write(new string(' ', stars - line));
//     Console.Write(new string('*', line));
//     Console.Write(" ");
//     Console.WriteLine(new string('*', line));
// }