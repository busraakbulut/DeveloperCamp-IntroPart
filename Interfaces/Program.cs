using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();

            //Project Manager
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();

    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added!");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated!");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added!");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated!");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager )
        {
            personManager.Add();
            
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();

        }
    }


}
