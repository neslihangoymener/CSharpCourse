using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager(10);
            customermanager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product  product2=new Product{ Id = 2, Name = "Computer" };

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personmanager = new PersonManager("Product");
            personmanager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();


            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
                 
        public void List()
        {
            Console.WriteLine("Listed! {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public  EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public  void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
           _entity = _entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity); 
        }
    }

    internal class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    static class Teacher
    {
        public static  int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }

        
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
