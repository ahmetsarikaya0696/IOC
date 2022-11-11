namespace IOC.ConsoleApp
{
    internal class BL
    {
        private IDAL _dal { get; set; }

        public BL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
