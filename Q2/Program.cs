using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Company
    {
        public string Name;
        public Employee[] employees;
        public int count;
        public Company()
        {
            count = 0;
            Name = "MUHID KHAN\'s Company";
            employees = new Employee[10];
        }
        public void addemployee(Employee employee)
        {
            employees[count] = employee;
            count++;
        }
        public void removeEmployee(int key)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeID == key)
                {

                    employees[i] = null;

                }
            }
        }
        
        public void remove(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeID == id)
                {
                    employees[i]= null;
                }
            }
        }
        public void display()
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i] != null) 
                {
                    Console.WriteLine("the employee ID is : {0}", employees[i].EmployeeID);
                    Console.WriteLine("the employee' First name  is : {0}", employees[i].FirstName);
                    Console.WriteLine("the employee's Last name  is : {0}", employees[i].LastName);
                    Console.WriteLine("the employee's Department is : {0}", employees[i].Department);
                    Console.WriteLine("the employee's Salary is : {0}", employees[i].Salary);
                    Console.WriteLine("------------------------------------------------");
                }
                
                else 
                {
                    continue;
                }
            }
        }
    }

    public class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public double Salary;
        public string Department;
        public Employee(int employeeID, string firstName, string lastName, double salary, string department)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Department = department;
        }
            public void display()
            {
                Console.WriteLine("the employee ID is : {0}", EmployeeID);
                Console.WriteLine("the employee' First name  is : {0}",FirstName);
                Console.WriteLine("the employee's Last name  is : {0}",LastName);
                Console.WriteLine("the employee's Department is : {0}",Department);
                Console.WriteLine("the employee's Salary is : {0}",Salary);
            }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "John", "Doe", 50000, "IT");
            Employee employee2 = new Employee(2, "Jane", "Smith", 55000, "HR");
            Employee employee3 = new Employee(3, "Mike", "Brown", 60000, "Finance");
            Employee employee4 = new Employee(4, "Emily", "Davis", 52000, "Marketing");
            Employee employee5 = new Employee(5, "David", "Wilson", 58000, "Operations");
            Company company = new Company();
            company.addemployee(employee1);
            company.addemployee(employee2);
            company.addemployee(employee3);
            company.addemployee(employee4);
            company.addemployee(employee5);
            Console.WriteLine("here is the list of employees: ");
            Console.WriteLine("------------------------------------");
            company.display();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("do you want to remove an employee??");
            string decision= Console.ReadLine();
            Console.Clear();
            if (decision == "yes")
            {
                Console.WriteLine("Enter the ID of the employee you wish to remove");
                int key = int.Parse (Console.ReadLine());
                company.remove(key);
            }
            Console.WriteLine("here is the list of employees after removing the employee: ");
            Console.WriteLine("------------------------------------");
            company.display();
            Console.WriteLine("------------------------------------");



        }
    }
}
