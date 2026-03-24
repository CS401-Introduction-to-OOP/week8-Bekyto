namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> _items;

    public CargoContainer()
    {
        _items = new List<T>();
    }
    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var t in _items)
        {
            totalCost += t.CalulateCost();
        }
        return totalCost;
    }
}