using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_task
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public override string ToString() => $"ID= {Id}\nName:{Name}\nCategory:{Category}\nPrice={Price}\nS0tock:{Stock}";

    }
}
