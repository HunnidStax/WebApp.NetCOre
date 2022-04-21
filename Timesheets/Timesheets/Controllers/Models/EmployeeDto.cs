namespace Timesheets.Controllers.Models
{
    public class EmployeeDto : PersonDto
    {
        //public int Id { get; set; }
        //public string EmployeeName { get; set; }
        public string Email { get; set; }
        //public string EmployeeSurname { get; set; }
        public string Role { get; set; }
    }
}
