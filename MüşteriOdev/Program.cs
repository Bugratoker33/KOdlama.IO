namespace MüşteriOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "buğra";
            customer.Surname = "toker";
            customer.Gelir = 16.000;
            Customer customer2 = new Customer();
            customer2.Id = 3;
            customer2.Name = "buğr23a";
            customer2.Surname = "to32ker";
            customer2.Gelir = 16.23000;


            Kredi kredi = new Kredi();
            kredi.Krediver(customer2);
            kredi.Krediver(customer);


            //  Console.WriteLine(costemer1);
           


            Console.WriteLine("Hello, World!");
        }
      

        
    }
}