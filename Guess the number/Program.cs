// See https://aka.ms/new-console-template for more information
using System;

Random rand = new Random();
int guess = 0;
int rangeStart, rangeEnd;
// validare, text mesaje
Console.WriteLine("Dati minNumber: ");
rangeStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dati maxNumber: ");
rangeEnd = Convert.ToInt32(Console.ReadLine());
int number = rand.Next(rangeStart, rangeEnd);

if (rangeStart > rangeEnd)
{
    Console.WriteLine("Nu exista niciun numar in intervalul introdus");
}
else
{

    while (guess != number)
    {
        Console.WriteLine("Dati guess: ");
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess > number)
        {
            Console.WriteLine("Valoarea {0} introdusa este prea mare ", guess);
        }
        else if (guess < number)
        {
            Console.WriteLine("Valoarea {0} introdusa este prea mica", guess);
        }


    }
}
Console.WriteLine("Valoarea {0} introdusa este corecta", guess);


