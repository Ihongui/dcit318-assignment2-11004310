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

    }
}
