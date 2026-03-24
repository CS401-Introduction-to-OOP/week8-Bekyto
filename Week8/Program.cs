
namespace Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            var lettr = new Letter("0", 0.1);
            lettr.PrintInfo();
            Console.WriteLine(lettr.CalulateCost());
            var prcl = new Parcel("1", 2.2, "10x10x10");
            prcl.PrintInfo();
            Console.WriteLine(prcl.CalulateCost());
            var crgo = new CargoContainer<DeliveryItem>();
            crgo.AddItem(lettr);
            crgo.AddItem(prcl);
            Console.WriteLine(crgo.GetTotalCost());
        }
    }
}
