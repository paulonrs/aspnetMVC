using System;
using System.Collections.Generic;

namespace aspnetmvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public double BaseSalary { get; set; }
        public List<SalesRecord> ListSalesRecord { get; set; }
        
        public void addSelles(SalesRecord sr)
        {
            ListSalesRecord.Add(sr);
        }
        public void removeSalles(SalesRecord sr)
        {
            ListSalesRecord.Remove(sr);
        }
        public double totalSales(DateTime initial, DateTime ending)
        {
            return 0;
        }
    }
}
