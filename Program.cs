class Program
{
    static void Main(string[] args)
    {
         Dog dog = new Dog();
        Dog.sound();
    }
}

virtual class Animal
{
    public virtual sound(){
        Console.WriteLine("Mooh");
    }
}

public class Dog : Animal
{
    public override sound(){
        Console.WriteLine("Woof");
    }
}