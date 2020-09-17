using System;

namespace BKIT_LAB6._2
{
    class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int DaysWorked { get; private set; }

        [SpecialProp]
        public double Balance { get; private set; }
        [SpecialProp]
        public double SalaryForDay { get; private set; }

        public Employee(string name, int age, int baseSalaryForDay)
        {
            Name = name;
            Age = age;
            SalaryForDay = baseSalaryForDay;
        }

        public void AddWorkedDays(int days)
        {
            for (int i = 0; i != days; ++i)
            {
                Balance += SalaryForDay;
                if (++DaysWorked % 90 == 0)
                    IncreaseSalary();
            }
        }

        private void IncreaseSalary()
        {
            SalaryForDay *= 1.2;
        }

        public void PaySalary()
        {
            Console.WriteLine($"{Balance}$ paid to {Name}.");
            Balance = 0;
        }

        public override string ToString()
        {
            return $"EMPLOYEE INFO:\n\t{Name} is {Age} years old.\n\t" +
                $"Worked for the company {DaysWorked} days.\n\t" +
                $"Salary rate is {SalaryForDay} for day ({SalaryForDay * 30} for month).\n\t" +
                $"Current balance is {Balance}$\n";
        }
    }
}
