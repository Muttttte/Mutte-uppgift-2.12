using System;
//Mustafauppgift 2.12
class program
{

    public static void Main()
    {
        int Startavgift = 300;
        Console.WriteLine("Hur många dagar ska du köra?");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Hur många kilometer ska du köra bilen?");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(Startavgift + x * 500 - 500 + y);

    }

}





