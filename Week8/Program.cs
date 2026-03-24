
namespace Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            var lettr = new Letter("0", 0.1);
            var prcl = new Parcel("1", 2.2, "10x10x10");
            var parcel = new Parcel("2", 6.7, "67x10x20");
            //1
            lettr.PrintInfo();
            prcl.PrintInfo();
            //2
            
            CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
            //3
            
            myCargo.AddItem(lettr);
            myCargo.AddItem(prcl);
            myCargo.AddItem(parcel);
            //4
            Console.WriteLine(myCargo.GetTotalCost());
            //5
        }
    }
}
