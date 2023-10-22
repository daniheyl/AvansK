using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool ContainsAlcohol { get; set; }

        public string Picture { get; set; }


        public Product() 
        { 
        
        }

        public Product(string name, bool containsAlcohol, string picture)
        {
            Name = name;
            ContainsAlcohol = containsAlcohol;
            Picture = picture;
        }

        public Product(int id, string name, bool containsAlcohol, string picture)
        {
            Id = id;
            Name = name;
            ContainsAlcohol = containsAlcohol;
            Picture = picture;
        }
    }
}
