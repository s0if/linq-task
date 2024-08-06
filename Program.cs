using System.Threading.Channels;

namespace linq_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Category = "Category A",
                    Price = 10.99m,
                    Stock = 100
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Category = "Category B",
                    Price = 20.99m,
                    Stock = 50
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Category = "Category C",
                    Price = 30.99m,
                    Stock = 75
                }
            };

            List<Customers> customers = new List<Customers>()
            {
                new Customers
                {
                    Id = 1,
                    Name = "Saif",
                    Email = "saif@example.com",
                    City = "Hebron",
                    PurchasedProducts = new List<Product> { Products[0], Products[1] }
                },
                new Customers
                {
                    Id = 2,
                    Name = "Ahmad",
                    Email = "ahmad@example.com",
                    City = "Nablus",
                    PurchasedProducts = new List<Product> { Products[1], Products[2] }
                },
                new Customers
                {
                    Id = 3,
                    Name = "Omar",
                    Email = "omar@example.com",
                    City = "Ramallah",
                    PurchasedProducts = new List<Product> { Products[0], Products[2] }
                },
                new Customers
                {
                    Id = 4,
                    Name = "Hassan",
                    Email = "hassan@example.com",
                    City = "Bethlehem",
                    PurchasedProducts = new List<Product> { Products[0], Products[1] }
                },
                new Customers
                {
                    Id = 5,
                    Name = "Khalid",
                    Email = "khalid@example.com",
                    City = "Nablus",
                    PurchasedProducts = new List<Product> { Products[1], Products[2] }
                },
                new Customers
                {
                    Id = 6,
                    Name = "Yousef",
                    Email = "yousef@example.com",
                    City = "Jenin",
                    PurchasedProducts = new List<Product> { Products[0], Products[2] }
                },
                new Customers
                {
                    Id = 7,
                    Name = "Ali",
                    Email = "ali@example.com",
                    City = "Tulkarm",
                    PurchasedProducts = new List<Product> { Products[0], Products[1] }
                },
                new Customers
                {
                    Id = 8,
                    Name = "Mohammad",
                    Email = "mohammad@example.com",
                    City = "Qalqilya",
                    PurchasedProducts = new List<Product> { Products[1], Products[2] }
                },
                new Customers
                {
                    Id = 9,
                    Name = "Ibrahim",
                    Email = "ibrahim@example.com",
                    City = "Nablus",
                    PurchasedProducts = new List<Product> { Products[0], Products[2] }
                },
                new Customers
                {
                    Id = 10,
                    Name = "Hussein",
                    Email = "hussein@example.com",
                    City = "Nablus",
                    PurchasedProducts = new List<Product> { Products[1], Products[2] }
                }
            };

            var customerCity = customers.Where(c => c.City == "Nablus");
            Console.WriteLine(string.Join("\n====================\n", customerCity));
            Console.WriteLine("\n-------------------------------\n");
            foreach (var customerName in customers)
            {
                Console.WriteLine(customerName.Name);
            }
            Console.WriteLine("\n-------------------------------\n");
            var customerNameOrder = customers.OrderBy(c => c.Name);
            Console.WriteLine(String.Join("\n====================\n", customerNameOrder));
            Console.WriteLine("\n-------------------------------\n");
            //var customerFind = customers.First();
            var customerFind = customers.FirstOrDefault();
            Console.WriteLine(customerFind);
            Console.WriteLine("\n-------------------------------\n");
            var customersId = customers.Find(cID => cID.Id == 1);
            Console.WriteLine(customersId);
            Console.WriteLine("\n-------------------------------\n");
            var customerCount= customers.SelectMany(p=>p.PurchasedProducts).Sum(p=>p.Price);
            Console.WriteLine($"count: {customerCount}");
            Console.WriteLine("\n-------------------------------\n");
            var customerSearch= customers.Any(s=>s.City== "Qalqilya");
            Console.WriteLine(customerSearch);
            var customerCroup=customers.GroupBy(c => c.City);
            foreach (var customerCgroup in customerCroup)
            {
                Console.WriteLine($"City is: {customerCgroup.Key}");
                foreach(var item  in customerCgroup)
                {
                    Console.WriteLine($"    the name is{item.Name}");
                }
            }
            Console.WriteLine("\n-------------------------------\n");
            var customerTake = customers.Take(3);
            Console.WriteLine(String.Join("\n======================================\n",customerTake));


        }
    }
}
