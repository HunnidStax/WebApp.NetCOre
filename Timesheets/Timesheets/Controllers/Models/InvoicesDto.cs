using System;

namespace Timesheets.Controllers.Models
{
    public class InvoicesDto
    {
        public ContractDto ContractId { get; set; }
        public DateTime? ContractStart { get; set; }
        public DateTime? Deadline { get; set; }
        public bool IsFinished { get; set; }
        public float SpentHours { get; set; }
    }
}
