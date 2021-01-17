using System;
using System.Collections.Generic;
using System.Text;

namespace KampIntro_Odevler
{
    class CustomerManager
    {

        public void add(Customer customer)
        {
            if (customer.Firstname !=null && customer.Lastname!=null &&customer.Id !=null )
            {

                Console.WriteLine("Customer saved");


            }
            else
            {
                Console.WriteLine("Registration failed");
            }



        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted:"+customer.Id);
         
        }

       







    }
}
