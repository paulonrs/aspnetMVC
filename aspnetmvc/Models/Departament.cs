using System;
using System.Collections.Generic;

namespace aspnetmvc.Models
{
    public class Departament
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Seller> ListSeller { get; set; }

        public Departament(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void AddSeller(Seller seller)
        {

        }
    }
}
