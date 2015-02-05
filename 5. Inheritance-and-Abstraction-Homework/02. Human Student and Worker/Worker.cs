using System;

namespace _02.Human_Student_and_Worker
{
    class Worker : Human
    {
        public Worker(string firstName, string lastName, int workHoursPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }
        public int WorkHoursPerDay { get; set; }
        public decimal WeekSalary { get; set; }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (this.WeekSalary / 5) / this.WorkHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return String.Format("Worker - First Name: {0}; Last Name: {1}; Payment per hour: {2:##} EURO",
                this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}