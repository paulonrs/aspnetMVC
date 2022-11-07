using System;
using System.Collections.Generic;

namespace aspnetmvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Seller> ListSeller { get; set; }

        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void AddSeller(Seller seller)
        {

        }
    }
}
