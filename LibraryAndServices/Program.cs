using MyClassLibrary;

namespace LibraryAndServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstCustomer = new Customer(1, "Richard", "rich@email.com");
            // Console.WriteLine(firstCustomer.Name);

            var customers = new List<Customer>
            {
                new Customer(1, "Richard", "rich@email.com"),
                new Customer(2, "Stefan", "stefan@email.com"),
                new Customer(3, "Linda", "linda@email.com"),
                new Customer(4, "Alicia", "alicia@email.com"),
            };

            foreach (var c in customers)
            {
                Console.WriteLine($"id: {c.CustomerId}, Name: {c.Name}, Email: {c.Email}");
            }



        }
    }
}
