﻿namespace Timesheets.Controllers.Models
{
    public class ContractDto : PersonDto
    {
        //public int Id { get; set; }
        public string ContractName { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
    }
}
