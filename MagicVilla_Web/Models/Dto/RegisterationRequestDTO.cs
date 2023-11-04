namespace MagicVilla_Web.Models.Dto
{
    public class RegisterationRequestDTO
    {
        //send back a 200ok to let them know registration was a success
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
