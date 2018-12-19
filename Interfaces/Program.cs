using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacecIntro();

            // Demo();

            ICustomerDal[] customerDals = new[] { new SqlServerCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void interfacecIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Neslihan",
                LastName = "KUŞ GÖYMENER",
                Adress = "Sarıyer"

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "AZRA NURAY",
                LastName = "GÖYMENER",
                Department = "Mathematic Engineer"
            };
            manager.add(customer);
            manager.add(student);
        }
    }
    interface IPerson 
    {
        int Id { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
    }
    class Customer : IPerson
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager 
    {
        public void add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
