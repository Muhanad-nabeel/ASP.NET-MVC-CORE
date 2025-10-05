namespace Demo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public decimal Salary { get; set; }

        public DateTime HDate { get; set; }
        public bool IsActive { get; set; }
    }
}
