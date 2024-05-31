using Prorotype_DP;

public class Car : IPrototype
{
    public int? Id { get; set; }
    private string CPF { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    private int Year { get; set; }

    public Car() 
    {
        this.CPF = "484.512.608-70";
        this.Name = "Celta";
        this.Color = "Prata";
        this.Year = 2005;
    }

    public Car(Car car)
    {
        CPF = car.CPF;
        Name = car.Name;
        Color = car.Color;
        Year = car.Year;
    }

    public IPrototype Clone() { return new Car(this); }

    public override string ToString()
    {
        return $"Id: {Id}\n" +
            $"CPF do dono: {CPF}\n" +
            $"Nome: {Name}\n" +
            $"Cor: {Color}\n" +
            $"Ano: {Year}\n";
    }
}