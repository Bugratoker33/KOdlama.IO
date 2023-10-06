using InterfaceAnstractDemo.Abstract;
using InterfaceAnstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnstractDemo.Concrete
{
    public class SturbucksCustomerManeger:BaseCostumerManeger
    {
        public override void Save(Costumer customer)
        {
            CheckIfRealPersson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPersson(Costumer customer)
        {
            throw new NotImplementedException();
        }
    }
}
