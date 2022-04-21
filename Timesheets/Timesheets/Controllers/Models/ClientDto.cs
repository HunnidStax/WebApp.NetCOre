namespace Timesheets.Controllers.Models
{
    public class ClientDto : PersonDto
    {
        //public int Id { get; set; }
        //public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string Email { get; set; }
    }
}
