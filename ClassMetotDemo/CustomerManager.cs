using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer registered"+ " "+ customer.Name+customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted" + " " + customer.Name +customer.Surname);
        }
    }
}
