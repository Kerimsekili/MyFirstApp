using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INTERFACE NEWLENEMEZ 
            //IPersonManager personManager = new CustomerManager();
            //personManager.Add();

            //IPersonManager employeePersonManager = new EmployeeManager();
            //employeePersonManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //Unimplemented Operation
        void Add();
        void Update();
    }

    //inherits - class ---------------implements -interface

    class CustomerManager:IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
