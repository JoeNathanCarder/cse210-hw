using System;

class Program
{
    static void Main(string[] args)
    {
    //This is code for making the console pause//
    Console.WriteLine("Going to sleep for a second...");
    Thread.Sleep(1000);
    Console.WriteLine("I'm back!!");

    While()
    {
        //Makes an animation.
        //Use the while loop somehow to wait for input maybe
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }
    
    //Works with time
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(5);
    Thread.Sleep(3000);
    DateTime currentTime = DateTime.Now;
    if (currentTime < futureTime)
    {
        Console.WriteLine("We have not arrived at our future time yet...")
    }

    }
    //I know this is far from complete but I am swamped. Have mercy plz.
}