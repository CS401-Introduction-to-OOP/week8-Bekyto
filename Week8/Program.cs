
namespace Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            var lettr = new Letter("0", 0.1);
            lettr.PrintInfo();
            var prcl = new Parcel("1", 2.2, "10x10x10");
            prcl.PrintInfo();
        }
    }
}
