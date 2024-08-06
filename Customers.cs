using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_task
{
    internal class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string City {  get; set; }
        public List<Product> PurchasedProducts { get; set; }
        public override string ToString() => $"ID= {Id}\nName: {Name}\nEmail: {Email}\nCity: {City}"+
            $"\nPurchased Products: {string.Join(", ", PurchasedProducts.Select(p => p.Name))}\n";


    }
}
