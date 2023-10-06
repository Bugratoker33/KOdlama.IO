using InterfaceAnstractDemo.Abstract;
using InterfaceAnstractDemo.Concrete;
using InterfaceAnstractDemo.Entities;

namespace InterfaceAnstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCostumerManeger costumerManeger = new NeroCustomerManeger();

            Costumer costumer= new Costumer();
            costumer.FirstName = "buğra";
            costumer.LastName = "toker";
            costumer.DateOfBirth = new DateTime(2002, 1, 7);
            costumer.Id = 1;
            costumer.NationalityId = "1234567";
            costumerManeger.Save(costumer);

            
        }
    }
}