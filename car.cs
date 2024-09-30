using System;

public class Car
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public const string CompanyName = "AutoCorp";

    public Car()
    {
        // Дефолтний конструктор
        Name = "DefaultCar";
        Color = "White";
        Price = 0;
    }

    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    public void Input()
    {
        Console.Write("Введіть назву автомобіля: ");
        Name = Console.ReadLine();
        Console.Write("Введіть колір автомобіля: ");
        Color = Console.ReadLine();
        Console.Write("Введіть ціну автомобіля: ");
        Price = Convert.ToDouble(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Автомобіль: {Name}");
        Console.WriteLine($"Колір: {Color}");
        Console.WriteLine($"Ціна: {Price} грн.");
        Console.WriteLine($"Компанія: {CompanyName}");
    }

    public void ChangePrice(double percentage)
    {
        Price *= (1 - percentage / 100);
    }

    public string PrintInfo()
    {
        return $"Автомобіль: {Name}, Колір: {Color}, Ціна: {Price} грн., Компанія: {CompanyName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[3];

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car();
            cars[i].Input();
        }

        // Зменшення ціни на 10%
        foreach (var car in cars)
        {
            car.ChangePrice(10);
            car.Print();
        }

        // Перефарбування автомобілів білого кольору
        Console.Write("Введіть новий колір для білих автомобілів: ");
        string newColor = Console.ReadLine();
        foreach (var car in cars)
        {
            if (car.Color == "white")
            {
                car.Color = newColor;
            }
        }

        // Виведення інформації про автомобілі в одному рядку
        foreach (var car in cars)
        {
            Console.WriteLine(car.PrintInfo());
        }
    }
}

















































































