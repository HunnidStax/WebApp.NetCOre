using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.Controllers.Models
{
    public class PersonDto
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Surname")]
        public string Surname { get; set; }
        [Column("Position")]
        public string Position { get; set; }
    }
}
