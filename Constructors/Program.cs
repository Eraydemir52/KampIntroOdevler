using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1,Firstname="Eray",Lastname="Demir",City="Ordu" };
            Customer customer2 = new Customer(2, "Güllü","Demir","Ordu");


            Console.WriteLine(customer2.Firstname);

        }
    }
    class Customer
    {
        public Customer()
        {

        }
        //defult constructor
        public Customer(int id,string firstName,string lastName,string city)
        {
            Firstname = firstName;
            Lastname = lastName;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}
