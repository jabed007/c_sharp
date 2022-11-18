namespace TupleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Customers Informations
            Customer[] customers = new Customer[2];

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Md. Jabed Hossain";
            customer1.Age= 30;

            customers[0] = customer1;
            customers[1] = new Customer()
            {
                Id = 2,
                Name = "Tareq",
                Age = 32
            };

            // Orders Informations
            Order[] orders = new Order[2];

            Order order1 = new Order();
            order1.ProductId = 001;
            order1.CustomerName = "Md. Jabed Hossain";
            order1.Price = 500;

            orders[0] = order1;
            orders[1] = new Order()
            {
                ProductId = 002,
                CustomerName = "Tareq",
                Price = 900
            };

            // Uses of Tuple
            (int id, double price)[] r = new (int id, double price)[2];
            int count = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                for (int j = 0; j < orders.Length; j++)
                {
                    if (customers[i].Name == orders[j].CustomerName)
                    {
                        r[count++] = (customers[i].Id, orders[j].Price);
                    }
                }
            }

            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine($"Customer Id: {r[i].id} Product Price: {r[i].price}");
            }

            // If we do not use tuple then we can solve the problem by following
            // We can solve the above problem by using class

            OrderInfo[] orderInfos= new OrderInfo[2];

            int counter = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                for (int j = 0; j < orders.Length; j++)
                {
                    if (customers[i].Name == orders[j].CustomerName)
                    {
                        orderInfos[counter++] = new OrderInfo() { CustomerId = customers[i].Id, ProductPrice = orders[j].Price };
                    }
                }
            }

            foreach(var orderInfo in orderInfos)
            {
                Console.WriteLine($"Customer Id: {orderInfo.CustomerId}, Product Price: {orderInfo.ProductPrice}");
            }
        }
    }
}