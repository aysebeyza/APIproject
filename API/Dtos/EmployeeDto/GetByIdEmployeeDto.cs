namespace API.Dtos.EmployeeDto
{
    public class GetByIdEmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public string IdentityNo { get; set; }
        public string InsuranceNumber { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public DateTime birthDay { get; set; }
    }
}
