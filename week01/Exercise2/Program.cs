using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

Console.Write("What is your grade persentage? ");
 String answer = Console.ReadLine();
 int percent = int.Parse(answer);

 string letter = "";

 if (percent >= 90)
 {
    letter = "A";
 }
else if (percent >= 80)
{
    letter = "B";
}
else if (percent >= 70)
{
    letter = "C";
}
else if (percent >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

Console.WriteLine($"your grade is: {letter}");
if (percent >= 70)

{
    Console.WriteLine("Congratulation you passed! ");
}
else
{
    Console.WriteLine("better luck next time");
}
    }
}