namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDto
    {
        public required string Name { get; init; }
        public required string Email { get; init; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
    }
}
