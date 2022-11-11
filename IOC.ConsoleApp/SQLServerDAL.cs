namespace IOC.ConsoleApp
{
    internal class SQLServerDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                // SQL Serverdan dataların alındığını düşünelim
                new () {Id = 1, Name="SQL Server Kalem 1", Price=100M, Stock=200},
                new () {Id = 2, Name="SQL Server Kalem 2", Price=300M, Stock=300},
                new () {Id = 3, Name="SQL Server Kalem 3", Price=500M, Stock=400},
                new () {Id = 4, Name="SQL Server Kalem 4", Price=700M, Stock=500},
            };
        }

        // Interface ' te geçmediği için bu IDAL bu metotu kullanamaz
        public int Hesapla()
        {
            return 100;
        }
    }
}
