namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; set; }
    public double Weight { get; set; }
    
    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalulateCost();
    
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Track number: {TrackingNumber} Weight: {Weight} kg");
    }


}