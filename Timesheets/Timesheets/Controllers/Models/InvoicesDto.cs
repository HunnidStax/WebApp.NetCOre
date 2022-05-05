using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.Controllers.Models
{
    [Table("Invoice", Schema - "Timesheets")]
    public class InvoicesDto
    {
        [Column("Id")]
        public ContractDto ContractId { get; set; }
        [Column("StartTime")]
        public DateTime? ContractStart { get; set; }
        [Column("Deadline")]
        public DateTime? Deadline { get; set; }
        [Column("IsFinished")]
        public bool IsFinished { get; set; }
        [Column("TotalHoursSpent")]
        public float SpentHours { get; set; }
    }
}
