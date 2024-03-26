namespace Udem.EfCore.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }

    public class PartTimeEmployee : Employee
    {
        public decimal DailyWage { get; set; }
    }

    public class FullTimeEmployee : Employee
    {
        public decimal HourlyWage { get; set; }

    }
}
