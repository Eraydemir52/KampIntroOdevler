using System;

namespace KampIntro_Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Firstname = "Eray";
            customer.Lastname = "Demir";
            customer.Id = "12345678901";
            customer.Balance = 200.000f;

            Customer customer2 = new Customer();
            customer2.Firstname = "Muhamed";
            customer2.Lastname = "Yücesoy";
            customer2.Id = "12345678902";
            customer2.Balance = 199.000f;


            Customer[] Customerarray = new Customer[] { customer, customer2 };


            foreach (var coustomer in Customerarray)
            {
                Console.WriteLine(coustomer.Firstname);
                Console.WriteLine(coustomer.Lastname);
                Console.WriteLine(coustomer.Id);
                Console.WriteLine(coustomer.Balance);
                Console.WriteLine("*********************");
            }

            CustomerManager customers = new CustomerManager();

            customers.add(customer);
            customers.Delete(customer);



        }

           
      







    }
}
