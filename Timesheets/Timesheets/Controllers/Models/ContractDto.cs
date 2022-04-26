using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.Controllers.Models
{
    public class ContractDto
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Title")]
        public string ContractName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Company")]
        public int CompanyId { get; set; }
    }
}
