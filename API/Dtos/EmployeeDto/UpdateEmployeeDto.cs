namespace API.Dtos.EmployeeDto
{
    public class UpdateEmployeeDto
    {


        public int EmployeeID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }      
        public string Department { get; set; }
        public string Gender    { get; set; } 

    }
}
