namespace Week8;

public class Parcel: DeliveryItem
{
  public string Dimentions { get; set; }
  public Parcel(string trackingNumber, double weight, string dimentions) : base(trackingNumber, weight)
  {
    Dimentions = dimentions;
  }

  public override double CalulateCost()
  {
    return 50 + (Weight * 25);
  }

  public override void PrintInfo()
  {
    base.PrintInfo();
    Console.WriteLine($"Dimentions: {Dimentions}");
  }
}