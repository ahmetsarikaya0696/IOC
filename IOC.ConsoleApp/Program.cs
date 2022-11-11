// tightly coupled koddan loosely couple koda doğru iyileştirme yapılarak devam edilecek
// O : Open-Closed Principle => DI sayesinde gelişime açık değişime kapalı bir kod yazmış olduk.

namespace IOC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BL bl = new(new SQLServerDAL()); // IOC kullanılsaydı burdaki kodu yazmamıza gerek kalmayacaktı

            bl.GetProducts().ForEach(p =>
            {
                Console.WriteLine($"{p.Id}-{p.Name}-{p.Price}-{p.Stock}");
            });

            Console.ReadLine();
        }
    }
}