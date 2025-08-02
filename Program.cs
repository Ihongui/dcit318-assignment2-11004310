using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Inheritance and Method Overriding ===");
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();
        Console.WriteLine("---======================---");
        animal.MakeSound();
        Console.WriteLine("---======================---");
        Console.WriteLine("---This is a dog Sound---");
        dog.MakeSound();
        Console.WriteLine("---======================---");
        Console.WriteLine("---This is a cat Sound---");
        cat.MakeSound();
        Console.WriteLine("---======================---");
        Console.WriteLine("---======================---");
        Console.WriteLine("---======================---");
        Console.WriteLine("\n=== Abstract Classes ===");
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine("---======================---");
        Console.WriteLine("---======================---");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

    }
}
