// tightly coupled koddan loosely couple koda doğru iyileştirme yapılarak devam edilecek

namespace IOC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BL bl = new();

            bl.GetProducts().ForEach(p =>
            {
                Console.WriteLine($"{p.Id}-{p.Name}-{p.Price}-{p.Stock}");
            });

            Console.ReadLine();
        }
    }
}