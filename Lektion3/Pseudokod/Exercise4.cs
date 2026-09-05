/*
ANGE en x-koordinat
ANGE en y-koordinat
RITA UT koordinaterna
*/

 public class Exercise4
 {
     public static void Main()
     {
         Console.Write("Ange x-koordinat: ");
         int x = int.Parse(Console.ReadLine());
         Console.Write("Ange y-koordinat: ");
         int y = int.Parse(Console.ReadLine());

         Console.WriteLine("y");
         for (int i = 5; i >= 0; i--)
         {
            Console.Write($"{i} *");
            if (y == i) {
                for (int j = 0; j <= 5; j++)
                {
                    if (x == j)
                    {
                        string spaces = new string(' ', (x*2)-1);
                        Console.Write($"{spaces}X");
                    }
                }
            }
            Console.WriteLine();
         }

         Console.WriteLine("  * * * * * *");
         Console.WriteLine("  0 1 2 3 4 5 x");
     }
 }