

namespace StartUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Test";
            customer.LastName = "Test";

            CustomerManager customerManager= new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.GetAll(customer);

            Console.ReadLine();
        }
    }
}