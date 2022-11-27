using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUI
{
    public class CustomerManager
    {
        public void GetAll(Customer customer)
        {
            Console.WriteLine("Müşteri Adı: "+customer.FirstName);
            Console.WriteLine("Müşteri Soyadı: " + customer.LastName);
        }

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "Adlı müşteri eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "Adlı müşteri silindi.");
        }
    }
}
