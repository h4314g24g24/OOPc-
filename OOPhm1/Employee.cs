using System;


namespace OOPhm1
{
    public class Employee
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string lastName, string firstName, string position, int experience)
        {
            LastName = lastName;
            FirstName = firstName;
            Position = position;
            Experience = experience;
        }

        public double CalculateSalary()
        {
            double baseSalary;

            switch (Position.ToLower())
            {
                case "hr":
                    baseSalary = 35000;
                    break;
                case "software developer":
                    baseSalary = 40000;
                    break;
                case "designer":
                    baseSalary = 30000;
                    break;
                default:
                    baseSalary = 11000;
                    break;
            }

            return baseSalary + Experience * 800;
        }

        public double CalculateTax()
        {
            double salary = CalculateSalary();
            return salary * 0.2; 
        }

        public void DisplayEmployeeInfo()
        {
            double salary = CalculateSalary();
            double tax = CalculateTax();

            Console.WriteLine($"Employee: {LastName} {FirstName}, Position: {Position}");
            Console.WriteLine($"Salary: {salary}, Tax: {tax}");
        }



    }
}
