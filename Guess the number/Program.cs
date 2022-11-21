// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");



Random rand = new Random();
int guess = 0;
int minNumber, maxNumber;
Console.WriteLine("Dati minNumber: ");
minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dati maxNumber: ");
maxNumber = Convert.ToInt32(Console.ReadLine());
int numar = rand.Next(minNumber, maxNumber);

while (guess != numar)
{
    Console.WriteLine("Dati guess: ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > numar)
    {
        Console.WriteLine("Valoarea {0} introdusa este prea mare ", guess);
    }
    else if(guess < numar)
    {
        Console.WriteLine("Valoarea {0} introdusa este prea mica", guess);
    }

    
}

Console.WriteLine("Valoarea {0} introdusa este corecta", guess);


