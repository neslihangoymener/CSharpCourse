using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IWorker
    {
        void work();


    interface IEat              
    {
        void Eat();
    }
     

    class Manager : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Eat()
        {
        
        }

        public void GetSalary()
        {
        
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
    
