using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.Controllers.Models
{
    public sealed class EmployeeDto : PersonDto
    {
        //public int Id { get; set; }
        //public string EmployeeName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        //public string EmployeeSurname { get; set; }
        [Column("Role")]
        public string Role { get; set; }
    }
}
