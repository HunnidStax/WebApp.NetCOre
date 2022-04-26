using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.Controllers.Models
{
    public class ClientDto : PersonDto
    {
        //public int Id { get; set; }
        //public string ClientName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
    }
}
