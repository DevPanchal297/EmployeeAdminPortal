namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        //public Employee(string name, string email, string? phone, decimal? salary, string? department, string? address)
        //{
        //    Id = Guid.NewGuid();
        //    Name = name;
        //    Email = email;
        //    Phone = phone;
        //    Salary = salary;
        //    Department = department;
        //    Address = address;
        //}

        public Employee()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public required string Name { get; init; }
        public required string Email { get; init; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
    }
}
