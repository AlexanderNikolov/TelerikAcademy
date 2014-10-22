using System;

namespace HumanSpace
{
    public class Worker : Human
    {
        private const decimal WorkingDaysOfWeek = 5;

        public uint WeekSalary { get; private set; }
        public uint WorkHoursPerDay { get; private set; }

        public Worker (string firstName, string lastName, uint salary, uint workingHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workingHours;
        }

        //
        public override string ToString()
        {
            return string.Format("{0, -4} {1, -5} {2} {3}", FirstName, LastName, this.WeekSalary, this.WorkHoursPerDay);
        }

        public string MoneyPerHour()
        {
            var result = this.WeekSalary / ( this.WorkHoursPerDay * WorkingDaysOfWeek);
            return string.Format("{0:C2}", result);
        }
    }
}
