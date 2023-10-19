using FactoryDesignPattern;


Car car = CarFactory.Create("Toyota");
Console.WriteLine(car.model);
