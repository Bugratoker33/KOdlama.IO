using InterfaceAnstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnstractDemo.Abstract
{
    public abstract class BaseCostumerManeger : ICustumerService
    {
        public virtual void Save(Costumer customer)
        {
            Console.WriteLine("Save to Db:"+customer.FirstName+ customer.DateOfBirth);
        }
    }
}
