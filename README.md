# Csharp1_Interfaces

In C#, an interface is a blueprint for a set of related methods, properties, events, or indexers. It defines a contract that a class can choose to implement, specifying the members that must be provided by any class that implements the interface. This allows for polymorphism and helps achieve loose coupling between classes.

Here's an example of an interface declaration in C#:

```csharp
public interface IShape
{
    double CalculateArea(); // Method declaration
    void Display(); // Method declaration
}
```

In the above code, we have declared an interface named IShape. It has two method declarations: CalculateArea() and Display(). Any class that implements this interface must provide implementations for these methods.

Now, let's create a class that implements the IShape interface:

```csharp
public class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle with length {length} and width {width}");
    }
}
```

In the above code, the Rectangle class implements the IShape interface by providing implementations for the CalculateArea() and Display() methods.

Here's an example of how you can use the IShape interface:

```csharp
class Program
{
    static void Main()
    {
        IShape shape = new Rectangle(5, 3);
        shape.Display();
        double area = shape.CalculateArea();
        Console.WriteLine($"Area: {area}");
    }
}
```

In the above code, we create an instance of the Rectangle class and assign it to a variable of the IShape interface type. This allows us to treat the rectangle object polymorphically as an IShape. We can call the Display() and CalculateArea() methods on the IShape variable, and the appropriate implementations from the Rectangle class will be executed.

Interfaces in C# provide a powerful way to define contracts and achieve abstraction and polymorphism in your code. They are widely used in various scenarios, such as defining APIs, implementing dependency injection, and facilitating testability.
