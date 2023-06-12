Cat cat = new Cat();
cat.Eat();   // Output: The cat is eating.
cat.Sleep(); // Output: The cat is sleeping.

Car car1 = new Car
{
    Make = "Toyota",
    Model = "Camry",
    Year = "2020"
};

Car car2 = new Car
{
    Make = "Toyota",
    Model = "Camry",
    Year = "2020"
};

Car car3 = new Car
{
    Make = "Honda",
    Model = "Accord",
    Year = "2021"
};

Console.WriteLine(car1.Equals(car2)); // true
Console.WriteLine(car1.Equals(car3)); // false

interface IAnimal
{
    void Eat();
    void Sleep();
}

class Cat : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("The cat is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("The cat is sleeping.");
    }
}

interface IEquatable<T>
{
    bool Equals(T obj);
}

public class Car : IEquatable<Car>
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? Year { get; set; }

    // Implementation of IEquatable<T> interface
    public bool Equals(Car? car)
    {
        return (this.Make, this.Model, this.Year) ==
            (car?.Make, car?.Model, car?.Year);
    }
}





