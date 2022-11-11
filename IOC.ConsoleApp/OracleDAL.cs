using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    internal class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                // Oracle'dan dataların alındığını düşünelim
                new () {Id = 1, Name="Oracle Kalem 1", Price=100M, Stock=200},
                new () {Id = 2, Name="Oracle Kalem 2", Price=300M, Stock=300},
                new () {Id = 3, Name="Oracle Kalem 3", Price=500M, Stock=400},
                new () {Id = 4, Name="Oracle Kalem 4", Price=700M, Stock=500},
            };
        }
    }
}
