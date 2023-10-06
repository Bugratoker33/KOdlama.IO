namespace OOP1
{// calsları 2 ye ayrılır ierisinde methotlarda anlatım 
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2; // 2 numara mobilyaya denk geliyor:
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,
                ProductName="Kalem",UnitPrice=35 };

            //PascalCase    //CamelCase
            ProductManeger productManeger = new ProductManeger();

            productManeger.Add(product1);
            Console.WriteLine(product1.ProductName);
            
            



        }
    }
}