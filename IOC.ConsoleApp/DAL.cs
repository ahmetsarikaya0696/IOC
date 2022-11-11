namespace IOC.ConsoleApp
{
    internal class DAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {Id = 1, Name="Kalem 1", Price=100M, Stock=200},
                new Product() {Id = 2, Name="Kalem 2", Price=300M, Stock=300},
                new Product() {Id = 3, Name="Kalem 3", Price=500M, Stock=400},
                new Product() {Id = 4, Name="Kalem 4", Price=700M, Stock=500},
            };
        }
    }
}
