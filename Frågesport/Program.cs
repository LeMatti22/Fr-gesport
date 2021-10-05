using System;

string name = "Matti";

int points = 0;

Console.WriteLine("Regler för frågesport:");
Console.WriteLine("Det kommer att finnas 4 svar för varje fråga,");
Console.WriteLine("skriv in svarets givna nummer i terminalen");
Console.WriteLine("för att svara på frågan. Du kommer att få ett");
Console.WriteLine("poäng för varje fråga du svarar rätt på. Du kommer");
Console.WriteLine("att få reda på hur många poäng och hur många poäng");
Console.WriteLine("du har efter varje runda.");

Console.WriteLine("För att starta skriv S i terminalen");

string start = Console.ReadLine();

if(start == "S")
{
Console.WriteLine();
}

Console.WriteLine("Första frågan: ")

Console.ReadLine();