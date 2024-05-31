using Prorotype_DP;

Car car = new();

Car novoCarro = new Car
{
    CPF = car.CPF,
    Name = car.Name,
    Color = car.Color
};

var clone = car.Clone();


Console.WriteLine(car);

Console.WriteLine(clone);