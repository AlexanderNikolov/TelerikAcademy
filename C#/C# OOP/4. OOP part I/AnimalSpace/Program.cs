using System;
using AnimalSpace;

public class Program
{
    static void Main()
    {
        //instances
        Tomcat fellowTomcat = new Tomcat("Tom", 38, "cartoon");
        Kitten prittyKitten = new Kitten("Blondi", 4, "persian");
        Dog heroDog = new Dog("Scooby-Doo", 50);

        //output
        Console.WriteLine("{0}, {1}, {2}", fellowTomcat.Name, fellowTomcat.Breed, fellowTomcat.Sex);
        fellowTomcat.MakeSound();
        
        Console.WriteLine("{0}, {1}, {2}", prittyKitten.Name, prittyKitten.Breed, prittyKitten.Sex);
        prittyKitten.MakeSound();

        Console.WriteLine("{0}", heroDog.Name);
        heroDog.MakeSound();
    }
}
