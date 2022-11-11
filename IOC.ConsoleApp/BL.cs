namespace IOC.ConsoleApp
{
    internal class BL
    {
        private IDAL _dal { get; set; }

        public BL()
        {
            _dal = DALFactory.GetDAL();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
